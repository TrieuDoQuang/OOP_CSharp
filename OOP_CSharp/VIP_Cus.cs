namespace OOP_CSharp
{
    public class VIP_Cus : Customer
    {
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.2;
        }
        public bool CheckID(string idvip)
        {
            if (idvip == this.ID)
            {
                return true;
            }
            return false;
        }
        ~VIP_Cus() { }
    }
}