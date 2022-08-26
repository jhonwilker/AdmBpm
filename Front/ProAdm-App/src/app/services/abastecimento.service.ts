import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Abastecimento } from '../models/Abastecimento';

@Injectable()
export class AbastecimentoService {

constructor(private http:HttpClient) { }

baseURL = 'https://localhost:5001/api/Abastecimento';

  public getAbastecimentos():Observable<Abastecimento[]> {
    return this.http.get<Abastecimento[]>(this.baseURL);
  }

  public getAbastecimentoById(id:number):Observable<Abastecimento> {
    return this.http.get<Abastecimento>(`${this.baseURL}/${id}`);
  }

}
