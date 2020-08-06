import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public numero: number;
  public divisores: Array<number>;
  public divString: string;
  public divPrimos: Array<number>;
  public primoString: string;

  public url = 'https://localhost:44311/api/';

  constructor (private _http: HttpClient) {

  }
  buscarDivisores() {
    this._http.get<any>(this.url + 'Divisores/' + this.numero).subscribe(
      result => {
        this.divisores = result.Divisores && result.Divisores.length > 0 ? result.Divisores : [];
        this.divPrimos = result.DivisoresPrimos && result.DivisoresPrimos.length > 0 ? result.DivisoresPrimos : [];
        this.divString = this.divisores.length > 0 ? this.retornaString(this.divisores) : 'Nenhum Divisor.';
        this.primoString = this.divPrimos.length > 0 ? this.retornaString(this.divPrimos) : 'Nenhum Divisor Primo.';
      }
    );
  }
  retornaString(numeros) {
    let retorno = '';
    numeros.forEach(element => {
      retorno += element + ', ';
    });
    retorno = retorno.substr(0, retorno.length - 2) + '.';

    return retorno;
  }
}
