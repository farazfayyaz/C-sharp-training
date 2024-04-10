string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}