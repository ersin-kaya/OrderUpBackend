using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//AssetTest();
//StatusTest();
//TypeTest();
//AccountTest();

static void AssetTest()
{
    AssetManager assetManager = new AssetManager(new EfAssetDal());

    //assetManager.Add(new Asset { AssetName="Asset for Accounts", AssetIcon="" });

    var result = assetManager.GetAll();

    foreach (var asset in result.Data)
    {
        Console.WriteLine("AssetId:{0} : {1}", asset.AssetId, asset.AssetName);
    }
}

static void StatusTest()
{
    StatusManager statusManager = new StatusManager(new EfStatusDal());

    //statusManager.Add(new Status { AssetId = 5, StatusName = "Aktif", StatusIcon = "" });
    //statusManager.Add(new Status { AssetId = 5, StatusName = "Pasif", StatusIcon = "" });

    var result = statusManager.GetAll();

    foreach (var status in result.Data)
    {
        Console.WriteLine("StatusId:{0} : {1} : AssetId:{2}", status.StatusId, status.StatusName, status.AssetId);
    }
}

static void TypeTest()
{
    TypeManager typeManager = new TypeManager(new EfTypeDal());

    //typeManager.Add(new Entities.Concrete.Type { AssetId = 5, TypeName = "Yönetici", TypeIcon = "" });
    //typeManager.Add(new Entities.Concrete.Type { AssetId = 5, TypeName = "Restoran", TypeIcon = "" });
    //typeManager.Add(new Entities.Concrete.Type { AssetId = 5, TypeName = "Müşteri", TypeIcon = "" });

    var result = typeManager.GetAll();

    foreach (var type in result.Data)
    {
        Console.WriteLine("TypeId:{0} : {1} : AssetId:{2}", type.TypeId, type.TypeName, type.AssetId);
    }
}

static void AccountTest()
{
    AccountManager accountManager = new AccountManager(new EfAccountDal());

    //accountManager.Add(new Account { AccountTypeId=1, AccountStatusId=1, FirstName="Ersin", LastName="Kaya", Email="test@account.test", Password="test1234", PhoneNumber="0 555 666 77 88", ProfilePhotoPath="" });

    var result = accountManager.GetAll();

    foreach (var account in result.Data)
    {
        Console.WriteLine("AccountId:{0} : {1} {2}", account.AccountId, account.FirstName, account.LastName);
    }
}