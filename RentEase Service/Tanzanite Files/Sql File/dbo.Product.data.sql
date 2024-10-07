-- Accommodation (4 Single Rooms)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Single Room in Auckland Park', 'Spacious single room with Wi-Fi and shared kitchen. Furnished.', 1, 2500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Accommodation', GETDATE(), '/Tanzanite Files/Accomodation/Room_2.webp'),
('Single Room in Melville', 'Cozy room with access to laundry and parking. Furnished.', 1, 2700.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Accommodation', GETDATE(), '/Tanzanite Files/Accomodation/Room_3.jpg'),
('Single Room in Randburg', 'Room with private bathroom. Utilities included.', 1, 3000.00, 1, 0, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Accommodation', GETDATE(), '/Tanzanite Files/Accomodation/Room_4.jpg'),
('Single Room in Craighall', 'Modern room with great natural light, near bus routes.', 1, 3200.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Accommodation', GETDATE(), '/Tanzanite Files/Accomodation/Room_5.jpg');

-- Sofas (5 Sofas)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Light Blue 4-Seater Sofa', 'Light blue sofa that can seat 3-4 people.', 3, 1200.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Couches/Sofa_1.jpg'),
('Dark Blue 3-Seater Sofa', 'Dark blue sofa that can seat 3 people.', 2, 1000.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Couches/Sofa_2.jpg'),
('Pink Sofa with Continental Pillows', 'Pink sofa with pink continental pillows.', 1, 1500.00, 1, 0, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Couches/Sofa_3.jpg'),
('Orange Leather Couch', 'Orange leather couch that can seat 3.', 2, 1800.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Couches/Sofa_4.jpg'),
('Luxury Leather Couch', 'Luxury leather couch with two sides, each seating 3.', 1, 2000.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Couches/Sofa_5.jpg');

-- Lamps (4 Lamps)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Beige Lamp', 'Simple beige lamp for living room.', 5, 300.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Lamps/Lamp_1.jpg'),
('Black Lamp', 'Black lamp for modern decor.', 4, 350.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Lamps/Lamp_2.jpg'),
('Black Lamp with Pink Cover', 'Black lamp with a pink cover.', 3, 400.00, 1, 0, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Lamps/Lamp_3.jpg'),
('Silver Lamp', 'Sleek silver lamp.', 2, 500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Lamps/Lamp_4.jpg');

-- Chairs (5 Chairs)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('White Plastic Kitchen Chair', '4 wooden legs with a white plastic seat.', 10, 400.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Chairs/Chair_1.jpg'),
('Light Brown Dinner Chair', 'Light brown dining room chair.', 6, 450.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Chairs/Chair_2.jpg'),
('Dark Brown Silk Chair', 'Dark brown silk chair.', 4, 600.00, 1, 0, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Chairs/Chair_3.jpg'),
('White Seat Wooden Chair', '4 wooden legs with a white seat.', 5, 500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Chairs/Chair_4.jpg'),
('Luxury Room Chair with Handles', 'Luxury room chair with handles.', 3, 800.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Chairs/Chair_5.jpg');

-- Tables (4 Tables)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Wooden Table with Two Tops', '4 legged wooden table with upper and lower top.', 2, 1500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Tables/Table_1.jpg'),
('Wooden Table with Drawers', '4 legged wooden table with tops and drawers beneath the upper top.', 2, 1700.00, 1, 0, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Tables/Table_2.jpg'),
('Wooden TV Stand Table', 'Wooden table with an upper top, 4 drawers, and 4 slots.', 1, 1800.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Tables/Table_3.jpg'),
('Simple Wooden Table', 'Simple 4 legged wooden table.', 3, 1000.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Tables/Table_4.jpg');

-- Fridges (5 Fridges)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Hisense 269L Inox Combi Fridge', 'Silver Hisense 269L Inox Combi Fridge.', 2, 3000.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Fridges/Fridge_1.avif'),
('SnoMaster 40L Stainless Steel Fridge', 'Silver SnoMaster 40L Stainless Steel Fridge.', 3, 3500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Fridges/Fridge_2.webp'),
('4L Multifunctional Retro Mini Fridge', 'Blue 4L Multifunctional Retro Mini Fridge.', 4, 1000.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Fridges/Fridge_3.jpg'),
('KIC 276L Metallic Fridge Freezer', 'Silver KIC 276L Metallic Fridge Freezer.', 1, 4500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Fridges/Fridge_4.jpg'),
('Elekta 138L Single Door Fridge', 'Elekta 138L Single Door Fridge with freezer.', 2, 2500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Fridges/Fridge_5.webp');

-- Microwaves (4 Microwaves)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Black 30 Litre Inverter Microwave Oven', 'Black 30 Litre Inverter Microwave Oven.', 3, 1500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Microwaves/Microwave_1.jpg'),
('Grey 20 Litre Swan Microwave', 'Grey 20L Swan Nordic Microwave Oven.', 4, 1400.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Microwaves/Microwave_2.jpg'),
('Silver Bennett Read 34L Microwave', 'Silver Bennett Read 34L Digital Microwave.', 2, 1600.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Microwaves/Microwave_3.jpg'),
('Silver Midea 30L Microwave', 'Silver Midea 30L Digital Microwave.', 1, 1700.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Electronics', GETDATE(), '/Tanzanite Files/Microwaves/Microwave_4.jpg');

-- Truck Moving Service (1 Service)
INSERT INTO [dbo].[Product] (Product_Name, Decript, Quantity, Price, M_ID, Available, Rental_Agreement, Category, Registration_Date, Image_URL) VALUES
('Truck Moving Service', 'Truck available to move items from one location to another. Price per hour.', 1, 500.00, 1, 1, '/Tanzanite Files/Rental Agreement/Default_Contract.pdf', 'Furniture', GETDATE(), '/Tanzanite Files/Moving Products/Truck_Service.jpg');


