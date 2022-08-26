import { Servidor } from "./Servidor";
import { Viatura } from "./Viatura";

export interface Abastecimento {
  id : number ;

  viatura :Viatura;

  kmAbastecimento : number;

  litrosAbastecimento : number;

  valorAbastecimento : number;

  dataAbastecimento :Date;

  responsavel : Servidor;

  convenio : string;

  saldo:number;

}
