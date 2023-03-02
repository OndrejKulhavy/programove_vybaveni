interface IDAO<T> {
    void Add(T t);
    void Update(T t);
    void Delete(int id);
    List<T> GetAll();
    bool hasTable();
    void CreateTable();
}