select *
from Printers

return

insert into PrinterTypes (Name)
Values ('Лазерный ч/б А4'), ('Струйный А3'), ('Лазерный ц А4')

insert into Vendors (Name)
Values ('Canon'), ('HP'), ('xerox'), ('kysera')

insert into PrinterModels (VendorId, TypeId)
Values (1, 1), (2, 2), (3, 1), (4, 1), (3, 3)

insert into Printers (ModelId, InventoryNum)
Values (1, 'ewrstfdhg'), (2, 'spdikishd')

insert into Roles (Name)
Values ('Admin'), ('User')

insert into Users (Name, Mail, RoleId, Password)
values ('Vlad', 'vladch@live.com', 1, '123')