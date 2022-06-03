insert into zona values
/*(codZ , nombre) */
(1, "Floresta"),
(2, "Flores"),
(3, "Caballito"),
(4, "Puerto Madero"),
(5, "Villa Devoto"),
(6, "Velez Sarsfield"),
(7, "Villa Luro"),
(8, "Versalles"),
(9, "Palermo"),
(10, "Recoleta"),
(11, "Monte Castro"),
(12, "Agronomia"),
(13, "Almagro"),
(14, "Balvanera"),
(15, "Barracas"),
(16, "Belgrano"),
(17, "Boedo"),
(18, "Chacarita"),
(19, "Coghlan"),
(20, "Colegiales"),
(21, "Constitución"),
(22, "Liniers"),
(23, "Mataderos"),
(24, "Monserrat"),
(25, "Nuñez"),
(26, "Parque Avellaneda"),
(27, "Parque Chacabuco"),
(28, "Parque Chas"),
(29, "Parque Patricios"),
(30, "Paternal"),
(31, "Pompeya"),
(32, "Retiro"),
(33, "Saavedra"),
(34, "San Cristobal"),
(35, "San Nicolás"),
(36, "San Telmo"),
(37, "Villa Crespo"),
(38, "Villa Del Parque"),
(39, "Villa Gral Mitre"),
(40, "Villa Lugano"),
(41, "Villa Ortúzar"),
(42, "Villa Pueyrredon"),
(43, "Villa Real"),
(44, "Villa Riachuelo"),
(45, "Villa Santa Rita"),
(46, "Villa Soldati"),
(47, "Villa Urquiza");


insert into persona values
/*(codP, tipoDoc, nroDoc, nom, ape, tel, direc, email, fNac, borrado, codZ)*/
(10000, "DNI", "21345679", "Martin", "Di natale", "1126453569", "Jose P Alvear 2500", "MartuDiNatu@gmail.com",  "1995/05/28",false, 3),
(10001, "DNI","23697854", "Maria", "Rodriguez", "11234695789", "Pedro Lozano 1250", "Mari_Ro@gmail.com", "1975/08/12",false, 2),
(10002, "DNI","32654897", "Jose", "Tarsikowsky", "1112345678", "Av San Martin 2659", "Josesito@gmail.com", "1990/07/13",false, 3),
(10003, "DNI","22336699", "David", "Robertone", "1178354297", "Baigorria 2456", "Da_robert@gmail.com", "1978/07/13",false, 2),
(10004, "DNI", "43404821", "Marcos", "Araujo", "1157982750", "José Pedro Varela 392", "marcosaraujo@gmail.com",  "2000/04/15",false, 1),
(10005, "DNI", "38304912", "Ariel", "Hernández", "1140308750", "Av. Lope de Vega 240", "hernandezariel@hotmail.com", "1996/03/22",false, 1),
(10006, "DNI", "72057182", "Jorge", "Nuñoz", "1140308750", "Sarachaga 2020", "jorgejorgin@gmail.com", "1983/09/01",false, 5),
(10007, "DNI", "44555666", "Ricardo","Fernández", "1112345678", "J.B. Justo 4680", "rfern@gmail.com", "1990/09/24",false, 1),
(10008, "DNI", "43456679", "Paula", "Rodríguez", "1111113333", "Av. Rivadavia 2990", "pau_rodri@hotmail.com", "1992/10/22",false, 2),
(10009, "DNI", "35444333", "Leandro", "Carrillo", "1145663344", "Sanabria 1000", "leandro_castillo_01@yahoo.com.ar",  "1983/12/08",false, 3),
(10010, "DNI", "45263846", "Mario", "Kempez", "1146480606", "Cesar Diaz 4706", "MarioInversiones@hotmail.com",  "1973/11/24",false, 1),
(10011, "DNI", "35461728", "Valentin", "Ciempes", "1101928439", "Bermudez 2380", "Ciempes_Helping@hotmail.bue.edu.ar",  "1980/08/08",false, 6),
(10012, "DNI", "37182946", "Pedro", "Tributario", "1175918394", "Aranguren 2648", "PedroDiputado@yahoo.com.ar", "1991/02/16",false, 6),
(10013, "DNI", "32819302", "Roberto", "Martinez", "1104920138", "Carrasco 4303", "Robertito@gmail.com",  "2001/09/25",false, 6),
(10014, "DNI", "64738291", "Marta", "Benitez", "1102948371", "Rivadavia 6804", "MartaTarta@yahoo.com.ar", "1999/10/13",false, 7),
(10015, "DNI", "94039281", "Rigoberto", "Susanez", "1162739402", "Av. San Pedrito 2309", "Susano@hotmail.com", "1997/01/01",false, 2),
(10016, "DNI", "48292819", "Lucas", "Gomes", "1131729012", "Calderon de la Barca 2021", "lucas.gomes@gmail.com", "2002/01/04",false, 8),
(10017, "DNI", "23023012", "Sebastian", "Ortega", "1122437502", "Av. Santa Fe 1305", "sebasort@hotmail.com", "1998/06/12",false, 9),
(10018, "DNI", "83726381", "Horacio", "Kinkel", "1121720432", "Lope de Vega 1992", "kinkelh@gmail.com", "1963/02/09",false, 10);

insert into Usuario values
/*(codUS, nickname, password, fcreac, codP)*/
(100, "Jorge", "J0rg3", "2008/03/23", 10006),
(101, "admin", "1234", curdate(), 10007),
(102, "Mary", "MaRy12", "2019/12/12", 10001),
(103, "Josesinio", "marte0349", "2020/03/18", 10002),
(104, "RoberDavid", "hoynotrabajo", "2019/11/03", 10003),
(105, "Marcos", "M4rc0s", "2020/07/25", 10004),
(106, "Hernandez", "elFacha2000", "2020/08/20", 10005),
(107, "Paula", "lasd0321", "2018/07/11", 10008),
(108, "Leandro", "pana043", "2019/05/04", 10009),
(109, "Mario", "masterchef", "2020/06/12", 10010),
(110, "Valen", "roscapascua", "2016/08/09", 10011),
(111, "Pedro", "capuzoto", "2018/12/15", 10012),
(112, "Roberto", "MM3v3", "2020/08/08", 10013),
(113, "Marta", "messirve", "2019/09/25", 10014),
(114, "Rigoberto", "villaNueva303", "2018/02/29", 10015),
(116, "Martin", "M4rt1n66", "2020/07/12", 10000),
(117, "Luks", "lukas911", "2020/08/26", 10016),
(118, "Sebas", "seba321", "2020/08/23", 10017),
(119, "Horacitten", "hkinkel63", "2020/08/12", 10018);

insert into Repartidor values
/*(codR, codP, disponible, fechaExpiraRegistro, borrado)*/
(1000, 10010, true, "2020/07/25", false),
(1001, 10011, true, "2021/08/19", false),
(1002, 10012, true, "2020/11/03", false),
(1003, 10013, true, "2021/08/08", false),
(1004, 10014, true, "2020/09/25", false),
(1005, 10015, true, "2019/02/29", false),
(1006, 10016, true, "2020/10/19", false),
(1007, 10017, true, "2021/10/31", false),
(1008, 10018, true, "2022/09/20", false);

insert into zonaRepartidor values
/*(codZ, codR)*/
(1 , 1000);

insert into VehiculoRegistrado values
/*(codVR, codR, tipo, color, marca, modelo, borrado)    tipo = [bicicleta|moto|automovil] */
(7400, 1000, "Automovil", "Rojo", "FIAT", "PALIO", false),
(7401, 1001, "Moto", "Rojo y Negro", "Aprilia", "Dorsoduro 1200 ABS ATC", false),
(7402, 1002, "Bicicleta", "Azul", "GT Bicycles", "Palomar AL Aluminio",false),
(7403, 1003, "Automovil", "Azul", "Audi", "A3", false),
(7404, 1004, "Moto", "Blanca y Verde", "BMW", "C evolution", false),
(7405, 1005, "Moto", "Rojo y Negro", "BMW", "F 800 GS Adventure", false),
(7406, 1006, "Moto", "Verde", "Kawasaki", "Ninja", false),
(7407, 1007, "Moto", "Negro y Gris", "Zanella", "RX 150", false),
(7408, 1008, "Automovil", "Gris", "Wolkswagen", "Gol", false);

insert into Automovil values
/*(codAUT, codVR, matricula) */
(5000, 7400, "RUT404"),
(5001, 7403, "AB 123 CD"),
(5002, 7408, "GOF126");

insert into Moto values
/*(codMOT, codVR, matricula)*/
(4300, 7401, "MN 853 NA"),
(4301, 7404, "OA 041 OD"),
(4302, 7405, "MF 402 OS"),
(4303, 7406, "MJ 210 RT"),
(4304, 7407, "JR 102 OP");

insert into Bicicleta values
/*(codBIC, codVR)*/
(200, 7402);

insert into Cliente values 
/*(codC, codP, borrado)*/
(1, 10000, false),
(2, 10001, false),
(3, 10002, false),
(4, 10003, false),
(5, 10004, false),
(6, 10006, false),
(7, 10007, false),
(8, 10008, false),
(9, 10009, false);

insert into TipoTarjeta values
/*(codT, marca, tipo, borrado)    tipo= [debito|credito]*/
(1, "VISA", "Debito", false),
(2, "Banco provincia", "Credito", false),
(3, "MasterCard", "Credito", false),
(4, "MasterCard", "Debito", false),
(5, "VISA", "Credito", false),
(6, "American Express", "Debito", false),
(7, "American Express", "Credito", false),
(8, "Diners Club", "Debito", false),
(9, "Diners Club", "Credito", false);

insert into TarjetaCliente values
/*(codTC, codC, codT, num, cod, fechVto, borrado)*/
(1, 2, 1, 1479203279243756, 646, "2022/12/16", false),
(2, 3, 1, 6780979671420931, 450, "2023/11/26", false),
(3, 1, 2, 8316469962898183, 749, "2029/08/02", false),
(4, 2, 3, 2651416295434783, 988, "2028/01/28", false),
(5, 4, 3, 2003041350326625, 752, "2027/06/12", false),
(6, 2, 2, 9575874301069072, 634, "2026/02/08", false);

insert into LocalAdherido values
/*(codLA, nom, direc, tel, codZ, borrado)*/
(1, "La rippa", "Sanabria 2700", "4567-9090", 3, false),
(2, "Pizzastico", "J.B. Justo 4000", "4676-9933", 2, false),
(3, "Empanadas al toque", "Baigorria 2500", "4755-8391", 4, false),
(4, "Burger King", "Av. Rivadavia 7408","4544-3839", 1, false),
(5, "McDonalds", "José Pedro Varela 4866","4566-4607", 1, false),
(6, "McDonalds", "Av. Francisco Beiró 5275", "1111-1111", 1, false),
(7, "Mostaza", "José Pedro Varela 4862", "5643-1805", 1, false),
(8, "Mostaza", "Av. Rivadavia 6912", "5430-6738", 2, false),
(9, "San Pedro", "Av. Álvarez Jonte 5001", "4566-3112", 11, false),
(10, "Farmacity", "Av. Rivadavia 8503", "4672-4178", 1, false),
(11, "El Gauchito", "Av. Rivadavia 9239", "4671-7730", 1, false),
(12, "One Up Golf", "Pedro Calderón de la Barca 626", "2122-2126", 1, false),
(13, "Ropa Deportiva Sport Amor", "Av. Rivadavia 6433", "4631-6138", 2, false);

insert into Elemento values
/*(codE, codLA, descripcion, PU, stock)*/
(1, 1, "Sandwich de Jamon y Queso",200,300),
(2, 2, "Pizza Mozzarella", 250, 200),
(3, 3, "Empanada de Carne", 50, 600),
(4, 4, "Hamburguesa Completa", 180, 1000),
(5, 5, "Hamburgusa con J/Q", 150, 1200),
(6, 5, "Papas fritas medianas", 80, 1500),
(7, 6, "Helado de vainilla", 540, 40),
(8, 6, "Papas fritas medianas", 80, 2000),
(9, 6, "Hamburgusa con J/Q", 150, 1700),
(11, 6, "Grand Triple McBacon", 230, 2000),
(10, 5, "Grand Triple McBacon", 230, 2300),
(12, 5, "Grand Doble McBacon", 210, 2000),
(13, 6, "Grand Doble McBacon", 210, 2300),
(14, 5, "Triple McNífica", 300, 1800),
(15, 6, "Triple McNífica", 300, 1500),
(16, 5, "Doble McNífica", 280, 2000),
(17, 6, "Doble McNífica", 280, 2100),
(18, 5, "Coca-Cola", 180, 2500),
(19, 6, "Coca-Cola", 180, 2300),
(20, 5, "Coca-Cola Light", 200, 2300),
(21, 6, "Coca-Cola Light", 200, 2000),
(22, 5, "Fanta", 180, 2500),
(23, 6, "Fanta", 180, 2300),
(24, 5, "Agua", 150, 3000),
(25, 6, "Agua", 150, 3000),
(26, 4, "Extra Burger", 270, 1500),
(27, 4, "Doble BK Stacker", 230, 1800),
(28, 4, "BK Stacker Triple", 260, 1500),
(29, 4, "BK Stacker Cuadruple", 300, 1300),
(30, 4, "Papas Regulares", 180, 2300),
(31, 4, "Aros de Cebolla", 500, 1500),
(32, 4, "Gaseosas", 180, 3000),
(33, 4, "Jugos", 170, 2300),
(34, 4, "Papas con Salsa Ciboullete", 230, 1800),
(35, 4, "Cono Relleno", 200, 2000),
(36, 7, "Pollo Deluxe", 200, 1500),
(37, 8, "Pollo Deluxe", 200, 1500),
(38, 7, "MEGA BOOM! Bacon", 300, 2000),
(39, 8, "MEGA BOOM! Bacon", 300, 2000),
(40, 7, "Doble MEGA Deluxe", 330, 1800),
(41, 8, "Doble MEGA Deluxe", 330, 1800),
(42, 7, "MEGA Bacon Cuarto", 300, 1900),
(43, 8, "Doble MEGA Napolitana", 280, 1300),
(44, 7, "Doble MEGA Napolitana", 280, 1300),
(45, 8, "MEGA Extra Cheddar", 270, 1400),
(46, 7, "MEGA Extra Cheddar", 270, 1400),
(47, 8, "MEGA Napolitana", 240, 1600),
(48, 7, "MEGA Napolitana", 240, 1600),
(49, 8, "Nuggets", 130, 2000),
(50, 7, "Nuggets", 130, 2000),
(51, 8, "MEGA Pollo Extra Cheddar", 210, 1500),
(52, 7, "MEGA Pollo Extra Cheddar", 210, 1500),
(53, 8, "Sundae", 190, 1800),
(54, 7, "Sundae", 190, 1800),
(55, 8, "MEGA Bacon Cuarto", 300, 1900),
(56, 10, "Pañales Pampers Pants Ajuste Total", 1141, 800),
(57, 10, "Crema Dental Oral-B Complete Doble Explosión x 90 g", 135, 700),
(58, 10, "Ropa interior Plenitud Femme pant g/xg x 8 Un", 828, 300),
(59, 10, "Ropa Interior Plenitud Protect Plus G/Xg x 8 Un", 840, 350),
(60, 10, "Shampoo Dream Long Elvive Loreal Paris x 400 Ml", 301, 900);

/*
insert into CuentaBancaria values
/*(codCB, CBU, titular, tipoMoneda, sucursalBanco, CUIT, codLA)
();
*/

insert into FormaPago values
/*(codFPago, descripcion)    descripcion = [efectivo|tarjeta]*/
(1, "Efectivo"),
(2, "Tarjeta");

insert into Pedido values
/*(codPED, codC, codLA, codFPago, fecha, horaPedido, horaRetiro, horaEntrega, estado)    estado = [pendiente|StockConfirmado|cancelado|confirmado]*/
(1, 2, 3, 1, "2020/03/14", "18:00", "18:10","18:30", "Pendiente"),
(2, 3, 4, 1, "2020/08/09", "20:30", "20:35","21:00", "Confirmado"),
(3, 4, 5, 2, "2020/06/20", "14:20", "14:25","14:50", "Confirmado"),
(4, 1, 2, 1, "2020/07/30", "15:55", "14:05","14:25", "Stock Confirmado"),
(5, 5, 6, 2, "2020/08/12", "20:45", "20:58", NULL, "Cancelado"),
(6, 6, 3, 1, "2020/04/16" , "13:15", "14:00", "14:05","Confirmado"),
(7, 6, 4, 1, "2020/04/16" , "13:15", NULL, NULL, "Cancelado"),
(8, 5, 4 ,1, "2020/03/14" , "18:00", NULL, NULL, "Pendiente");

/*
insert into Transaccion values
/*(codTRA, codCBOrigen, codCBDestino, codPED, monto, fecha, motivo)
();
*/

insert into DetallePedido values
/*(codDP, codPED, codE, cant, PU)*/
(40000, 1, 3, 5, 50),
(40001, 2, 5, 2, 150),
(40002, 3, 6, 6, 80),
(40003, 4, 1, 1, 250),
(40004, 5, 7, 2, 40),
(40005, 5, 6, 4, 80),
(40006, 6, 3, 12, 50),
(40009, 7, 32, 2, 180),
(40010, 7, 27, 2, 230),
(40011, 8, 4, 1, 51);

insert into SolicitudAtencionPedido values
/*(codSAP, codPED, estado)    estado = [pendiente|aceptada|cancelada]*/
(30000, 5, "aceptada"),
(30001, 8, "pendiente");
/*(30002, 7, "cancelada")*/

insert into SolicitudRepartidor values
/*(codSR, codSAP, codR, estado)    estado = [sin retirar|en caja|en camino|entregada|cancelada]*/
(35000, 30000, 1000, "en camino");

/*Las horas son las miasmas que la del pedido, habria que ver si es la hora en que se genera la Notas de Credito*/
insert into NotaCredito values
/*(codNota, codPED, costoDevuelto, fecha, hora)*/
(6000, 5, 60, "2020/08/12", "20:45"),
(6001, 7, 123, "2020/04/16", "13:15");


insert into Motivo values
/*(codMotivo, descripcionMotivo)*/
(2500, "No puedo pagarlo"),
(2501, "Arrepentimiento"),
(2502, "No podre atender al repartidor al momento de la entrega");

insert into Cancelacion values
/*(codCanc, codPED, codMotivo)*/
(1910, 5, 2500);


insert into MotivoMulta values
/*(codMM, descripcion)*/
(2000, "El cliente no se encuentra en el domicilio"),
(2001, "Accidente automovilistico"),
(2002, "Accidente en el local"),
(2003, "El cliente no pago el monto total correspondiente"),
(2004, "El client no quiere pagar");


/*
insert into Multa values
/*(codM, codC, codMM, notacion, monto)
(100, 6, 2004, "", );
*/

/*
insert into DescuentoSueldo values
/*(codD, codPED, monto, codR)
(2000, );
*/
