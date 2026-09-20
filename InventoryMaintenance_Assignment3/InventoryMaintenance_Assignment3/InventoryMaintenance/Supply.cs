namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        // GEORGE FELDMANN
        public Supply() { }

        // GEORGE FELDMANN
        public Supply(int itemNo, string description, decimal price, string manufacturer)
            : base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        public string Manufacturer { get; set; } = string.Empty;

        // GEORGE FELDMANN
        public override string GetDisplayText() =>
            $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
    }
}
