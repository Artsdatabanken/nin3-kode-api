﻿select Hovedtypegruppe.Kode, Hovedtypegruppe.Typekategori3, Type.Ecosystnivaa from Hovedtypegruppe, Type where Hovedtypegruppe.TypeId = Type.Id and Type.Ecosystnivaa=2