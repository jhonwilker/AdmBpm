
import { Component, OnInit } from '@angular/core';
import { Abastecimento } from '../models/Abastecimento';
import { AbastecimentoService } from '../services/abastecimento.service';

@Component({
  selector: 'app-abastecimentos',
  templateUrl: './abastecimentos.component.html',
  styleUrls: ['./abastecimentos.component.scss']
})
export class AbastecimentosComponent implements OnInit {

  public abastecimentos : Abastecimento[] = [];
  //public abastecimento  : Abastecimento;

  constructor(private abastecimentoService:AbastecimentoService) {

   }

  public ngOnInit() {
    this.getAbastecimentos();
  }

  public getAbastecimentos():void {

    this.abastecimentoService.getAbastecimentos().subscribe(
      
      (_abastecimentos:Abastecimento[]) => {
        this.abastecimentos = _abastecimentos;
      },
      error => console.log(error)
    );

  }

  // public getAbastecimento(id: number):void {

  //   this.abastecimentoService.getAbastecimentoById(id).subscribe(
  //     response => this.abastecimento = response,
  //     error => console.log(error)
  //   );

  // }
}
