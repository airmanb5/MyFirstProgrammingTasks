class StopWatch
{
    private bool _IsRunning = true;

    private DateTime _StartTime;

    public DateTime Start()
    {
        if (!_IsRunning)
        {
            throw new InvalidOperationException("The Stopwatch is already running");
        }
            _StartTime = DateTime.Now;

            _IsRunning = false;

            return DateTime.Now;
        
    }

    public TimeSpan Stop()
    {
       if (_IsRunning)
        {
            throw new InvalidOperationException("The Stopwatch hasn't been started yet.");
        }
        
        _IsRunning = true;

        return DateTime.Now - _StartTime;

    }
}
