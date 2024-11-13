


using Microsoft.Data.SqlClient;
 
SqlConnection con = new SqlConnection("Server=db4856.public.databaseasp.net; Database=db4856; User Id=db4856; Password=Ni4!7@wA-E2r; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
SqlCommand command=new SqlCommand("select product_name from Product",con);
con.Open();
SqlDataReader reader=command.ExecuteReader();
while(reader.Read()){
 
   Console.WriteLine("Ad : "+reader["product_name"]);
 
}
reader.Close();
con.Close();
