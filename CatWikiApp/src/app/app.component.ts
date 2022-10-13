import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  breeds: Breed[] = [
    {
      id: 'toyg',
      name: 'Toyger',
      url: 'https://cdn2.thecatapi.com/images/O3F3_S1XN.jpg',
    },
    {
      id: 'sava',
      name: 'Savannah',
      url: 'https://cdn2.thecatapi.com/images/a8nIYvs6S.jpg',
    },
    {
      id: 'emau',
      name: 'Egyptian Mau',
      url: 'https://cdn2.thecatapi.com/images/TuSyTkt2n.jpg',
    },
    {
      id: 'nebe',
      name: 'Nebelung',
      url: 'https://cdn2.thecatapi.com/images/OGTWqNNOt.jpg',
    },
  ];
}

export interface Breed {
  id: string;
  name: string;
  url: string;
}

// export class AppComponent {
//   public forecasts?: WeatherForecast[];

//   constructor(http: HttpClient) {
//     http.get<WeatherForecast[]>('/weatherforecast').subscribe(result => {
//       this.forecasts = result;
//     }, error => console.error(error));
//   }

//   title = 'CatWikiApp';
// }

// interface WeatherForecast {
//   date: string;
//   temperatureC: number;
//   temperatureF: number;
//   summary: string;
// }
