using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 综合练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过属性拿到父类
            Computer cpu = new Computer();
            MobileStorageDevice disk = new MobileDisk();
            MobileStorageDevice mp3 = new MP3();
            MobileStorageDevice up = new UP();
            cpu.Ms = disk;
            cpu.CpuRead();
            cpu.CpuWrite();
            cpu.Ms = mp3;
            cpu.CpuRead();
            cpu.CpuWrite();
            cpu.Ms = up;
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();

        }


        /// <summary>
        /// 可移动存储设备
        /// </summary>
        public abstract class MobileStorageDevice
        {
            public abstract void Read();
            public abstract void Write();
        }
        /// <summary>
        /// 移动硬盘
        /// </summary>
        public class MobileDisk : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是移动硬盘");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是移动硬盘");
            }
        }
        /// <summary>
        /// MP3
        /// </summary>
        public class MP3 : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是MP3");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是MP3");
            }
        }
        /// <summary>
        /// u盘
        /// </summary>
        public class UP : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是u盘");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是u盘");
            }
        }

        public class Computer
        {
            MobileStorageDevice _ms;

            internal MobileStorageDevice Ms { get => _ms; set => _ms = value; }

            public void CpuRead()
            {
                this.Ms.Read();
            }

            public void CpuWrite()
            {
                this.Ms.Write();
            }
        }
    }
}
