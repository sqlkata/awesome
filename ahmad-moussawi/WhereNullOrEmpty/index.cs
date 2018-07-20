public Query WhereNullOrEmpty(this Query query, string column)
{
    return query.WhereNull(column).OrWhereRaw($"LENGTH(TRIM({column})) = 0")
}