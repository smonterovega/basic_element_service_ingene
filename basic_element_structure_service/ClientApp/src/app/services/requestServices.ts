import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { getBaseUrl } from "../../main";
import {Element} from "../models/Element"
import { Observable } from 'rxjs';
const HTTP_OPTION = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};
@Injectable()
export class RequestServices {
  constructor(
    private http: HttpClient
  ) {

  }
  getAllElements(): Observable<Element[]> {
    return this.http.get<Element[]>("api/ElementDatabase/getallelement");
  }
  createElement(element: Element): Observable<boolean> {
    return this.http.post<boolean>('api/ElementDatabase/addelement', element, HTTP_OPTION);
  }
}
