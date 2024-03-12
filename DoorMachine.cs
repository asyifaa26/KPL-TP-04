public enum DoorState
{
    Terkunci,
    Terbuka
}
public enum Action
{
    BukaPintu,
    KunciPintu
}
public class DoorMachine
{
    private DoorState currentState;
    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
    }

    Transition[] transisi =
    {
         new Transition(DoorState.Terkunci, DoorState.Terkunci, Action.KunciPintu),
         new Transition(DoorState.Terbuka, DoorState.Terkunci, Action.KunciPintu),
         new Transition(DoorState.Terkunci, DoorState.Terbuka, Action.BukaPintu),
         new Transition(DoorState.Terbuka, DoorState.Terbuka, Action.BukaPintu),
    };

    public DoorState GetNextState(DoorState stateAwal, Action action)
    {
        DoorState stateAkhir = stateAwal;
        for (int i = 0; i < transisi.Length; i++)
        {
            Transition perubahan = transisi[i];
            if (stateAwal == perubahan.stateAwal && action == perubahan.action)
            {
                stateAkhir = perubahan.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void DoAction(Action action)
    {
        if (action == Action.BukaPintu)
        {
            Console.WriteLine("Membuka Pintu...");
        }
        else if (action == Action.KunciPintu)
        {
            Console.WriteLine("Mengunci Pintu...");
        }

        currentState = GetNextState(currentState, action);

        if (currentState == DoorState.Terbuka)
        {
            Console.WriteLine("Pintu Terbuka");
        }
        else if (currentState == DoorState.Terkunci)
        {
            Console.WriteLine("Pintu Terkunci");
        }
    }
}

public class Transition
{
    public DoorState stateAwal;
    public DoorState stateAkhir;
    public Action action;
    public Transition(DoorState stateAwal, DoorState stateAkhir, Action action)
    {
        this.stateAwal = stateAwal;
        this.stateAkhir = stateAkhir;
        this.action = action;
    }
}