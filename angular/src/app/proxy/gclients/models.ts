import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateGClientDto {
  nomComplet: string;
  cin: string;
  email?: string;
  dateNais: string;
  num: number;
  adresse: string;
  pathImg: string;
}

export interface GClientDto extends AuditedEntityDto<string> {
  nomComplet?: string;
  cin?: string;
  email?: string;
  dateNais?: string;
  num: number;
  adresse?: string;
  pathImg: string;
}
