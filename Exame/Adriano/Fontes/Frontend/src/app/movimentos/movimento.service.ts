import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class MovimentoService {
  private apiUrl = 'http://localhost:5000/api';

  constructor(private http: HttpClient) {}

  getMovimentos(ano: number, mes: number) {
    return this.http.get<any[]>(`${this.apiUrl}/movimentos/${ano}/${mes}`);
  }

  inserirMovimento(movimento: any) {
    return this.http.post<any>(`${this.apiUrl}/movimentos`, movimento);
  }

  getProdutos() {
    return this.http.get<any[]>(`${this.apiUrl}/produtos`);
  }

  getCosifs(codProduto: string) {
    return this.http.get<any[]>(`${this.apiUrl}/produtocosif/${codProduto}`);
  }
}
