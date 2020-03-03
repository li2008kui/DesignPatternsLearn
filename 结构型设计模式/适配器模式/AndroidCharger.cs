using System;

namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// Android 充电器。
    /// </summary>
    public class AndroidCharger : IMicroUsbCharger
    {
        /// <summary>
        /// 给 Android 手机充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        public void AndroidCharge(PhoneType type)
        {
            if (type == PhoneType.Android)
            {
                Console.WriteLine("正在给Android手机充电");
            }
            else
            {
                Console.WriteLine("接口不匹配，无法给Android以外的手机充电！");
            }
        }
    }
}
