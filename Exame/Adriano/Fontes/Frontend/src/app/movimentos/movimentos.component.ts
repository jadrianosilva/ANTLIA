import { Component, OnInit } from '@angular/core';
import { MovimentoService } from './movimento.service';

@Component({
  selector: 'app-movimentos',
  templateUrl: './movimentos.component.html'
})
export class MovimentosComponent implements OnInit {
  movimentos: any[] = [];
  produtos: any[] = [];
  cosifs: any[] = [];
  novo: any = {};

  constructor(private service: MovimentoService) {}

  ngOnInit() {
    this.service.getProdutos().subscribe(data => this.produtos = data);
  }

  carregarMovimentos(ano: number, mes: number) {
    this.service.getMovimentos(ano, mes).subscribe(data => this.movimentos = data);
  }

  onProdutoChange(codProduto: string) {
    this.service.getCosifs(codProduto).subscribe(data => this.cosifs = data);
  }

  inserirMovimento() {
    this.service.inserirMovimento(this.novo).subscribe(() => {
      this.carregarMovimentos(this.novo.datAno, this.novo.datMes);
      this.novo = {};
      this.cosifs = [];
    });
  }

  limpar() {
    this.novo = {};
    this.cosifs = [];
  }
}
