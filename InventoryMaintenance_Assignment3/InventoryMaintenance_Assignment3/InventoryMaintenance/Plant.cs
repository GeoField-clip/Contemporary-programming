namespace InventoryMaintenance
{
    // Plant signifies inheritance because ": InvItem" means Plant derives from InvItem
    
    // and inherits the accessible properties and methods defined by InvItem.
    public class Plant : InvItem
    {
        // GEORGE FELDMANN
        public Plant() { }

        // GEORGE FELDMANN
        public Plant(int itemNo, string description, decimal price, string size)
            : base(itemNo, description, price)
        {
            Size = size;
        }

        public string Size { get; set; } = string.Empty;

        // GEORGE FELDMANN
        public override string GetDisplayText() =>
            $"{ItemNo}    {Size} {Description} ({Price:c})";
    }
}
