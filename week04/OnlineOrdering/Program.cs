Address address1 = new("742 Jacksonvile ", "Florida", "FL", "USA");
Customer customer1 = new("Manuel Moreno", address1);

Order order1 = new(customer1);
order1.AddProduct(new Product("Wireless Mouse", "PRD-101", 28.50, 2));
order1.AddProduct(new Product("USB-C Hub 7-in-1", "PRD-204", 34.00, 1));
order1.AddProduct(new Product("Ipad 12", "PRD-309", 9.50, 3));

Address address2 = new("Av. Winston Churchill 120", "Santo Domingo", "Distrito Nacional", "Dominican Republic");
Customer customer2 = new("Camila Peña", address2);

Order order2 = new(customer2);
order2.AddProduct(new Product("Magic Keaboard", "PRD-412", 45.00, 1));
order2.AddProduct(new Product("Ipad case", "PRD-518", 32.00, 2));

List<Order> orders = new() { order1, order2 };

for (int i = 0; i < orders.Count; i++)
{
    Order currentOrder = orders[i];
    Console.WriteLine($"**************** ORDER #{i + 1} ****************");
    Console.WriteLine(currentOrder.GetPackingLabel());
    Console.WriteLine();
    Console.WriteLine(currentOrder.GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine($"Shipping Fee: ${currentOrder.GetShippingCost():F2}");
    Console.WriteLine($"Total Price:  ${currentOrder.GetTotalCost():F2}");
    Console.WriteLine();
}