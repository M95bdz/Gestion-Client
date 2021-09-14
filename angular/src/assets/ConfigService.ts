import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
    export class ConfigService {

      constructor(private http: HttpClient) { }

      getImage(path: string){
        return  this.http.get('/api/image?name=' + encodeURIComponent(path));
}
    }