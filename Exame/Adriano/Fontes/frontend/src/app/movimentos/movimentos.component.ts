import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MovimentoService } from './movimento.service';

@Component({
  selector: 'app-movimentos',
  standalone: true,
  imports: [CommonModule, FormsModule, HttpClientModule],
  templateUrl: './movimentos.component.html'
})
export class MovimentosComponent implements OnInit {
  movimentos: any[] = [];
  produtos: any[] = [];
  cosifs: any[] = [];
  novo: any = {};

  constructor(private service: MovimentoService) {}

  ngOnInit(): void {
    this.service.getProdutos().subscribe((data: any[]) => this.produtos = data);
  }

  carregarMovimentos(ano: number, mes: number): void {
    this.service.getMovimentos(ano, mes).subscribe((data: any[]) => this.movimentos = data);
  }

  onProdutoChange(codProduto: string): void {
    this.service.getCosifs(codProduto).subscribe((data: any[]) => this.cosifs = data);
  }

  inserirMovimento(): void {
    this.service.inserirMovimento(this.novo).subscribe(() => {
      this.carregarMovimentos(this.novo.datAno, this.novo.datMes);
      this.novo = {};
      this.cosifs = [];
    });
  }

  limpar(): void {
    this.novo = {};
    this.cosifs = [];
  }
}
