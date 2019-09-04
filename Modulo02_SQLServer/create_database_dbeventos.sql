use master
go

CREATE DATABASE DB_EVENTOS
ON
(
  NAME = DB_EVENTOS_DAT,
  FILENAME='C:\Users\ta0503\Documents\Sinqia_AspNet\Data\DbEventos.mdf',
  SIZE = 5000KB,
  MAXSIZE=UNLIMITED,
  FILEGROWTH=1000KB 
)

LOG ON 
(
  NAME = DB_EVENTOS_LOG,
  FILENAME='C:\Users\ta0503\Documents\Sinqia_AspNet\Data\DbEventos_log.ldf',
  SIZE = 2000KB,
  MAXSIZE=UNLIMITED,
  FILEGROWTH=1000KB                                                                                        
);
GO