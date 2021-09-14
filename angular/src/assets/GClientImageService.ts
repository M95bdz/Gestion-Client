import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

/*export class CarImageService {
    apiUrl = "https://localhost:44327/api/";
    constructor(private httpClient : HttpClient) { }

    getGClientImages() : Observable<ListResponseModel<GClientImage>>{
    let newPath = this.apiUrl + "gclientimages/getall";
    return this.httpClient.get<ListResponseModel<GClientImage>>(newPath);
    }

    getGClientImagesById(gclientId: number) : Observable<ListResponseModel<CarImage>>{
    let newPath = this.apiUrl + "gclientimages/getimagesbycarid?id=" + gclientId;
    return this.httpClient.get<ListResponseModel<GClientImage>>(newPath);
    } 
}*/