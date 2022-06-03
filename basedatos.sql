drop database if exists Flash_Delivery;
create database Flash_Delivery;
use Flash_Delivery;

create table Zona(
codZ int primary key,
nombre varchar(50)
)Engine = InnoDB;

create table Persona(
codP int primary key,
tipoDoc varchar(20),
nroDoc varchar(15),
nom varchar(30),
ape varchar(50),
tel varchar(15),
direc varchar(50),
email varchar(50),
fNac date,
borrado boolean,
codZ int,
constraint fk_Persona_Zona foreign key (codZ) references Zona(codZ)
) Engine=InnoDB;

create table Repartidor(
codR int primary key,
codP int,
disponible boolean,
fechaExpiraRegistro date,
borrado boolean,
constraint fk_Repartidor_Persona foreign key (codP) references Persona(codP)
)Engine = InnoDB;


create table VehiculoRegistrado(
codVR int primary key,
codR int,
tipo varchar(20),
color varchar(20),
marca varchar(20),
modelo varchar(20),
borrado boolean,
constraint fk_VehiculoRegistrado_Repartidor foreign key (codR) references Repartidor (codR)
)Engine = InnoDB;

create table Automovil(
codAUT int primary key, 
codVR int, 
matricula varchar(7), 
constraint fk_Automovil_VehiculoRegistrado foreign key (codVR) references VehiculoRegistrado(codVR)
)Engine = InnoDB;


create table Moto(
codMOT int primary key, 
codVR int, 
matricula varchar(7), 
constraint fk_Moto_VehiculoRegistrado foreign key (codVR) references VehiculoRegistrado(codVR)
)Engine = InnoDB;

create table Bicicleta(
codBIC int primary key, 
codVR int,  
constraint fk_Bicicleta_VehiculoRegistrado foreign key (codVR) references VehiculoRegistrado(codVR)
)Engine = InnoDB;


create table Cliente(
codC int primary key,
codP int,
borrado boolean,
constraint fk_cliente_persona foreign key (codP) references Persona (codP)
) Engine = InnoDB;


create table TipoTarjeta(
codT int primary key,
marca varchar(50),
tipo varchar(7),
borrado boolean
) Engine = InnoDB;

create table TarjetaCliente(
codTC int primary key,
codC int,
codT int,
num long,
cod int,
fechVto date,
borrado boolean,
constraint fk_TarjetaCliente_Tarjeta foreign key (codT) references TipoTarjeta(codT),
constraint fk_TarjetaCliente_Cliente foreign key (codC) references Cliente(codC)
) Engine=InnoDB;

create table LocalAdherido(
codLA int primary key,
nom varchar(60),
direc varchar(50),
tel varchar(15),
codZ int,
borrado boolean,
constraint fk_LocalAdherido_Zona foreign key (codZ) references Zona(codZ)
) Engine = InnoDB;


create table Elemento(
codE int primary key,
codLA int,
descripcion varchar(50),
PU float,
stock int,
constraint fk_Elemento_LocalAdherido foreign key (codLA) references LocalAdherido(codLA)
)Engine = InnoDB;

create table CuentaBancaria(
codCB int primary key,
CBU int, 
titular varchar(80),
tipoMoneda varchar(20),
sucursalBanco varchar(50),
CUIT varchar(15),
codLA int,
constraint fk_CuentaBancaria_LocalAdherido foreign key (codLA) references LocalAdherido(codLA)
)Engine = InnoDB;


create table FormaPago(
codFPago int primary key,
descripcion varchar(20)
)Engine = InnoDB;

create table Pedido(
codPED int primary key,
codC int,
codLA int,
codFPago int,
fecha date,
horaPedido time,
horaRetiro time,
horaEntrega time,
estado varchar(20),
constraint fk_Pedido_Cliente foreign key (codC) references Cliente(codC),
constraint fk_Pedido_LocalAdherido foreign key (codLA) references LocalAdherido(codLA),
constraint fk_Pedido_FormaPago foreign key (codFPago) references FormaPago(codFPago)
)Engine=InnoDB;

create table Transaccion(
codTRA int primary key,
codCBOrigen int,
codCBDestino int,
codPED int,
montodeenvio float, 
montopedido float,
fecha date,
motivo varchar(100),
constraint fk_Transaccion_CuentaOrigen foreign key (codCBOrigen) references CuentaBancaria(codCB),
constraint fk_Transaccion_CuentaDestino foreign key (codCBDestino) references CuentaBancaria(codCB),
constraint fk_Transaccion_Pedido foreign key (codPED) references Pedido(codPED)
)Engine = InnoDB;

create table PagoLocal(
codPL int primary key,
codTRA int,
codPED int,
monto int,
fecha date,
constraint fk_PagoLocal_Pedido foreign key (codPED) references Pedido(codPED),
constraint fk_PagoLocal_Transaccion foreign key (codTRA) references Transaccion(codTRA)
)Engine = InnoDB;


create table DetallePedido(
codDP int primary key,
codPED int,
codE int,
cant int,
PU float,
constraint fk_DetallePedido_Pedido foreign key (codPED) references Pedido(codPED),
constraint fk_DetallePedido_Elemento foreign key (codE) references Elemento (codE)
)Engine = InnoDB;

create table FacturaPedido(
codFP int primary key,
codPED int,
fecha date,
monto float,
constraint fk_FacturaPedido_Pedido foreign key(codPED) references Pedido(codPED)
)Engine = InnoDB;

create table FacturaDistancia(
codFD int primary key,
codPED int,
fecha date,
monto float,
constraint fk_FacturaDistancia_Pedido foreign key(codPED) references Pedido(codPED)
)Engine = InnoDB;


create table FacturaTotal(
codFT int primary key,
codPED int,
fecha date,
monto float,
codFP int,
codFD int,
constraint fk_FacturaTotal_Pedido foreign key(codPED) references Pedido(codPED),
constraint fk_FacturaTotal_FacturaPedido foreign key (codFP) references FacturaPedido(codFP),
constraint fk_FacturaTotal_FacturaDistancia foreign key (codFD) references FacturaDistancia(codFD)
)Engine = InnoDB;


create table SolicitudAtencionPedido(
codSAP int primary key,
codPED int,
estado varchar(10),
constraint fk_SolicitudAtencionPedido_Pedido foreign key (codPED) references Pedido(codPED)
)Engine = InnoDB;

create table SolicitudRepartidor(
codSR int primary key,
codSAP int,
codR int,
estado varchar(20),
constraint fk_SolicitudRepartidor_SolicitudAtencionPedido foreign key (codSAP) references SolicitudAtencionPedido(codSAP),
constraint fk_SolicitudRepartidor_Repartidor foreign key (codR) references Repartidor (codR)
)Engine=InnoDB;


create table NotaCredito(
codNota int primary key,
codPED int,
costoDevuelto float,
fecha date,
hora time,
constraint fk_NotaCredito_Pedido foreign key (codPED) references Pedido(codPED)
)Engine = InnoDB;

create table Motivo(
codMotivo int primary key,
descripcionMotivo varchar(50)
)Engine=InnoDB;

create table Cancelacion(
codCanc int primary key,
codPED int,
codMotivo int,
constraint fk_Cancelacion_Pedido foreign key (codPED) references Pedido(codPED),
constraint fk_Cancelacion_Motivo foreign key (codMotivo) references Motivo(codMotivo)
)Engine=InnoDB;

create table MotivoMulta(
codMM int primary key,
descripcion varchar(50)
)Engine=InnoDB;

create table Multa(
codM int primary key,
codC int,
codMM int,
notacion varchar(100),
monto float,
constraint fk_Multa_Cliente foreign key (codC) references Cliente (codC),
constraint fk_Multa_MotivoMulta foreign key (codMM) references MotivoMulta(codMM)
)Engine=InnoDB;

create table DescuentoSueldo(
codD int primary key,
codPED int,
monto float,
codR int,
constraint fk_DescuentoSueldo_Pedido foreign key (codPED) references Pedido(codPED),
constraint fk_DescuentoSueldo_Repartidor foreign key (codR) references Repartidor(codR)
)Engine=InnoDB;

create table TempDetallePedido(
codTDP int primary key auto_increment,
codE int,
cant int,
PU float,
constraint fk_TempDetallePedido_Elemento foreign key (codE) references Elemento(codE)
)Engine=InnoDB;

create table usuario(
codUS int primary key,
nickname varchar(20),
password varchar(20),
fcreac date,
codP int,
constraint fk_usuario_persona foreign key (codP) references Persona(codP)
)Engine=InnoDB;


create table ZonaRepartidor(
codZ int,
codR int,
constraint fk_ZonaRepartidor_Zona foreign key (codZ) references Zona(codZ),
constraint fk_ZonaRepartidor_Repartidor foreign key (codR) references Repartidor(codR)
)Engine=InnoDB;


create table RepartidorCancEnvio(
codRCE int auto_increment primary key,
codPED int,
codR int,
codMotivo int,
constraint fk_repartidor_cancela_pedido foreign key (codPED) references Pedido(codPED),
constraint fk_repartidor_cancela_rep foreign key (codR) references Repartidor(codR),
constraint fk_repartidor_cancela_motivo foreign key (CodMotivo) references Motivo(codMotivo)
)Engine = InnoDB;