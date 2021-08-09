export interface PagedResponse<T> {
  pageNumber: number;
  pageSize: number;
  totalPages: number;
  totalRecords: number;
  statusCode: number;
  search: string;
  errors: any;
  data: T[];


}

export interface response<T> {
  success: boolean;
  statusCode: number;
  errors: string[];
  data: T;


}

