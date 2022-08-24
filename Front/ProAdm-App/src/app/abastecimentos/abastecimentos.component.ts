import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-abastecimentos',
  templateUrl: './abastecimentos.component.html',
  styleUrls: ['./abastecimentos.component.scss']
})
export class AbastecimentosComponent implements OnInit {

  public abastecimentos :any = [];

  constructor(private http:HttpClient) {

   }

  ngOnInit() {
    this.getAbastecimentos();
  }

  public getAbastecimentos():void {

    this.http.get('https://localhost:5001/api/Abastecimento').subscribe(
      response => this.abastecimentos = response,
      error => console.log(error)
    );

  }
}
