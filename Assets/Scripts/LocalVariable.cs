using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class LocalVariable : MonoBehaviour
    {
        int _health = 100;

        private void Start()
        {
            OtherTest();
            OtherTest();
            Test();
            Test();

        }

        void Test()
        {
            int number = 100;             //區域變數.只存在宣告他的成員裡
            number ++;
        }

        void OtherTest()
        {
            _health++;
        }
    }
}