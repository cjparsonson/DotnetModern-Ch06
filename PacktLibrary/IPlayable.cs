namespace Packt.Shared;
public interface IPlayable
{
    void Play();
    void Pause();
    void Stop() // default implementation
    {
        WriteLine("Default implementation of Stop.");
    }
}