using System;

public class GachaEventArgs : EventArgs
{
    public int Number { get; }
    public string ItemName { get; }

    public bool IsWin => !string.IsNullOrEmpty(ItemName);

    public GachaEventArgs(int number, string itemName)
    {
        this.Number = number;
        this.ItemName = itemName;
    }
}
   