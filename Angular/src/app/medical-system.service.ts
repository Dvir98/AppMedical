import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MedicalSystemService {

  constructor(private http: HttpClient) { }

  GetMedicalIndices() {
    return this.http.get("https://localhost:44398/api/Medicals"); 
  }

  Add(value){
    console.log("value");
    return this.http.post("https://localhost:44398/api/Insert",value); 
  }
}
