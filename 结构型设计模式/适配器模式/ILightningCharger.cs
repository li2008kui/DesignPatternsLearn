namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// Lightning 接口的充电器。
    /// </summary>
    public interface ILightningCharger
    {
        /// <summary>
        /// 给 iPhone 手机充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        void iPhoneCharge(PhoneType type);
    }
}
