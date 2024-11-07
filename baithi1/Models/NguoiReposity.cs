namespace baithi1.Models
{
    public static class NguoiReposity
    {
        private static readonly List<Nguoi> ListNguoi = new List<Nguoi>();

        public static IEnumerable<Nguoi> Getlist { get {  return ListNguoi; } }

        public static void addNguoi (Nguoi nguoi)
        {
            ListNguoi.Add(nguoi);
        }
        public static void XoaNguoi (Nguoi nguoi)
        {
            ListNguoi.Remove(nguoi);
        }
        public static void EditNguoi (Nguoi nguoi)
        {
            Nguoi editNguoi = ListNguoi.FirstOrDefault(p => p.Id == nguoi.Id);
            if (editNguoi != null)
            {
                editNguoi.Id = nguoi.Id;
                editNguoi.tuoi = nguoi.tuoi;
                editNguoi.Description = nguoi.Description;
                editNguoi.Name = nguoi.Name;
            }
        }
        public static Nguoi GetNguoi (int id)
        {
            return ListNguoi.FirstOrDefault(p => p.Id == id);
        }

    }
}
