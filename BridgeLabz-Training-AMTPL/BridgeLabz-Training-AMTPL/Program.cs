
using BridgeLabz_Training_AMTPL.AccessModifiers;

PublicExample pub = new PublicExample();
pub.ShowValues();

InternalExample internalEx = new InternalExample();
internalEx.ShowInheritedValues();

TestAccess test = new TestAccess();
test.Run();