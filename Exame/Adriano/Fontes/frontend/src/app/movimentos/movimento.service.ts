import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class MovimentoService {
  private apiUrl = 'http://localhost:5000/api';

  constructor(private http: HttpClient) {}

  getMovimentos(ano: number, mes: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/movimentos/${ano}/${mes}`);
  }

  inserirMovimento(movimento: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/movimentos`, movimento);
  }

  getProdutos(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/produtos`);
  }

  getCosifs(codProduto: string): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/produtocosif/${codProduto}`);
  }
}