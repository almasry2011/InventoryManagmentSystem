export interface GetAllRequest<T> {
  pageNumber: number | undefined;
  pageSize: number | undefined;
  search?: string | undefined;
  Filter?: T[] | undefined;
}
