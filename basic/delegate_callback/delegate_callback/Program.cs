
using System;
using System.Threading.Tasks;

namespace delegate_callback
{
    internal class Program
    {
        public delegate void callbackDlg(bool res);
        static void Main(string[] args)
        {
            callbackDlg afterSomeMethod = CallbackHandler;
            // 非同期処理
            Task task = Task.Run(() =>
            {
                SomeMethod(afterSomeMethod);
            });

            // 何かの処理
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("メイン処理 {0}", i);
            }

            Console.ReadLine();
        }

        static void SomeMethod(callbackDlg callback)
        {
            // 何かの処理
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("非同期処理 {0}", i);
            }

            // Callback型のDelegate実行。SomeMethodの実行結果（true固定）を渡す
            callback(true);
        }
        // コールバック関数
        static void CallbackHandler(bool res)
        {
            Console.WriteLine("非同期処理の終了。res:{0}", res);
        }

    }
}
