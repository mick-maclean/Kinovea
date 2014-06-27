﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinovea.Tests.Metadata;
using Kinovea.Tests.HistoryStackTester;
using System.Threading;

namespace Kinovea.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TestKVAFuzzer();
            //TestKSVFuzzer();
            //TestHistoryStack();
            //TestDistortion();
            TestLineClipping();
            
        }
        private static void TestKVAFuzzer()
        {
            KVAFuzzer20 fuzzer = new KVAFuzzer20();
            fuzzer.CreateKVA(@"C:\Users\Joan\Dev  Prog\Videa\Experiments\KVAFuzzer");
        }

        private static void TestKSVFuzzer()
        {
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                KSVFuzzer fuzzer = new KSVFuzzer();
                fuzzer.CreateKSV(@"C:\Users\Joan\Dev  Prog\Videa\Experiments\KSVFuzzer");
                Thread.Sleep(1000);
            }
        }

        private static void TestHistoryStack()
        {
            try
            {
                HistoryStackSimpleTester tester = new HistoryStackSimpleTester();
                tester.Test();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void TestDistortion()
        {
            DistortionTester tester = new DistortionTester();
            tester.Test();
        }

        private static void TestLineClipping()
        {
            LineClippingTester tester = new LineClippingTester();
            tester.Test();
        }
    }
}
