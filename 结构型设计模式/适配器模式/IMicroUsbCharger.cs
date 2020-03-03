namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// Micro USB 接口的充电器。
    /// </summary>
    public interface IMicroUsbCharger
    {
        /// <summary>
        /// 给 Android 手机充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        void AndroidCharge(PhoneType type);
    }
}
