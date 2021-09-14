import type { CreateUpdateGClientDto, GClientDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class GClientService {
  apiName = 'Default';

  create = (input: CreateUpdateGClientDto) =>
    this.restService.request<any, GClientDto>({
      method: 'POST',
      url: '/api/app/g-client',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/g-client/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, GClientDto>({
      method: 'GET',
      url: `/api/app/g-client/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<GClientDto>>({
      method: 'GET',
      url: '/api/app/g-client',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateGClientDto) =>
    this.restService.request<any, GClientDto>({
      method: 'PUT',
      url: `/api/app/g-client/${id}`,
      body: input,
    },
    { apiName: this.apiName });

    
  constructor(private restService: RestService) {}
}
