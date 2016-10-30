import { Injectable } from '@angular/core';

@Injectable()
export class AppSettings {
  constructor() {

  }
  private _Environment: string = ENV;
  private _apiUrl = {
    "development": "http://api.baseproject",
    "production": "http://api.baseproject"
  }

  ApiUrl(): string {
    return this._apiUrl[this._Environment];
  }
}
