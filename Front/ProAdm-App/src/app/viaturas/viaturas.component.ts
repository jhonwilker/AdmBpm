import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-viaturas',
  templateUrl: './viaturas.component.html',
  styleUrls: ['./viaturas.component.scss']
})
export class ViaturasComponent implements OnInit {

  public viaturas :any;

  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getViaturas();
  }


  public getViaturas():void {

    this.http.get('https://localhost:5001/api/Viatura').subscribe(
      response => this.viaturas = response, error => console.log(error)
    );

  }
}
