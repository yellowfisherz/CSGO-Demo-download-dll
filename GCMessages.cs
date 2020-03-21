#pragma warning disable 1591


namespace libShareCodeToURL
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameServerPing")]
  public partial class GameServerPing : global::ProtoBuf.IExtensible
  {
    public GameServerPing() {}
    

    private ulong _gameserver_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gameserver_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong gameserver_id
    {
      get { return _gameserver_id; }
      set { _gameserver_id = value; }
    }

    private int _ping = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ping", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ping
    {
      get { return _ping; }
      set { _ping = value; }
    }

    private uint _ip = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ip
    {
      get { return _ip; }
      set { _ip = value; }
    }

    private uint _port = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint port
    {
      get { return _port; }
      set { _port = value; }
    }

    private uint _instances = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"instances", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint instances
    {
      get { return _instances; }
      set { _instances = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DetailedSearchStatistic")]
  public partial class DetailedSearchStatistic : global::ProtoBuf.IExtensible
  {
    public DetailedSearchStatistic() {}
    

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }

    private uint _search_time_avg = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"search_time_avg", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint search_time_avg
    {
      get { return _search_time_avg; }
      set { _search_time_avg = value; }
    }

    private uint _players_searching = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"players_searching", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint players_searching
    {
      get { return _players_searching; }
      set { _players_searching = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TournamentPlayer")]
  public partial class TournamentPlayer : global::ProtoBuf.IExtensible
  {
    public TournamentPlayer() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private string _player_nick = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_nick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_nick
    {
      get { return _player_nick; }
      set { _player_nick = value; }
    }

    private string _player_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_name
    {
      get { return _player_name; }
      set { _player_name = value; }
    }

    private uint _player_dob = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"player_dob", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_dob
    {
      get { return _player_dob; }
      set { _player_dob = value; }
    }

    private string _player_flag = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"player_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_flag
    {
      get { return _player_flag; }
      set { _player_flag = value; }
    }

    private string _player_location = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"player_location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_location
    {
      get { return _player_location; }
      set { _player_location = value; }
    }

    private string _player_desc = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"player_desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_desc
    {
      get { return _player_desc; }
      set { _player_desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TournamentTeam")]
  public partial class TournamentTeam : global::ProtoBuf.IExtensible
  {
    public TournamentTeam() {}
    

    private int _team_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id
    {
      get { return _team_id; }
      set { _team_id = value; }
    }

    private string _team_tag = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"team_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string team_tag
    {
      get { return _team_tag; }
      set { _team_tag = value; }
    }

    private string _team_flag = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"team_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string team_flag
    {
      get { return _team_flag; }
      set { _team_flag = value; }
    }

    private string _team_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"team_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string team_name
    {
      get { return _team_name; }
      set { _team_name = value; }
    }
    private readonly global::System.Collections.Generic.List<TournamentPlayer> _players = new global::System.Collections.Generic.List<TournamentPlayer>();
    [global::ProtoBuf.ProtoMember(5, Name=@"players", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentPlayer> players
    {
      get { return _players; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TournamentEvent")]
  public partial class TournamentEvent : global::ProtoBuf.IExtensible
  {
    public TournamentEvent() {}
    

    private int _event_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_id
    {
      get { return _event_id; }
      set { _event_id = value; }
    }

    private string _event_tag = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"event_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string event_tag
    {
      get { return _event_tag; }
      set { _event_tag = value; }
    }

    private string _event_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"event_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string event_name
    {
      get { return _event_name; }
      set { _event_name = value; }
    }

    private uint _event_time_start = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"event_time_start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint event_time_start
    {
      get { return _event_time_start; }
      set { _event_time_start = value; }
    }

    private uint _event_time_end = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"event_time_end", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint event_time_end
    {
      get { return _event_time_end; }
      set { _event_time_end = value; }
    }

    private int _event_public = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"event_public", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_public
    {
      get { return _event_public; }
      set { _event_public = value; }
    }

    private int _event_stage_id = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"event_stage_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_stage_id
    {
      get { return _event_stage_id; }
      set { _event_stage_id = value; }
    }

    private string _event_stage_name = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"event_stage_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string event_stage_name
    {
      get { return _event_stage_name; }
      set { _event_stage_name = value; }
    }

    private uint _active_section_id = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"active_section_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint active_section_id
    {
      get { return _active_section_id; }
      set { _active_section_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GlobalStatistics")]
  public partial class GlobalStatistics : global::ProtoBuf.IExtensible
  {
    public GlobalStatistics() {}
    

    private uint _players_online = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"players_online", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint players_online
    {
      get { return _players_online; }
      set { _players_online = value; }
    }

    private uint _servers_online = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"servers_online", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint servers_online
    {
      get { return _servers_online; }
      set { _servers_online = value; }
    }

    private uint _players_searching = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"players_searching", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint players_searching
    {
      get { return _players_searching; }
      set { _players_searching = value; }
    }

    private uint _servers_available = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"servers_available", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint servers_available
    {
      get { return _servers_available; }
      set { _servers_available = value; }
    }

    private uint _ongoing_matches = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ongoing_matches", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ongoing_matches
    {
      get { return _ongoing_matches; }
      set { _ongoing_matches = value; }
    }

    private uint _search_time_avg = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"search_time_avg", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint search_time_avg
    {
      get { return _search_time_avg; }
      set { _search_time_avg = value; }
    }
    private readonly global::System.Collections.Generic.List<DetailedSearchStatistic> _search_statistics = new global::System.Collections.Generic.List<DetailedSearchStatistic>();
    [global::ProtoBuf.ProtoMember(7, Name=@"search_statistics", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DetailedSearchStatistic> search_statistics
    {
      get { return _search_statistics; }
    }
  

    private string _main_post_url = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"main_post_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string main_post_url
    {
      get { return _main_post_url; }
      set { _main_post_url = value; }
    }

    private uint _required_appid_version = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"required_appid_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint required_appid_version
    {
      get { return _required_appid_version; }
      set { _required_appid_version = value; }
    }

    private uint _pricesheet_version = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"pricesheet_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pricesheet_version
    {
      get { return _pricesheet_version; }
      set { _pricesheet_version = value; }
    }

    private uint _twitch_streams_version = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"twitch_streams_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint twitch_streams_version
    {
      get { return _twitch_streams_version; }
      set { _twitch_streams_version = value; }
    }

    private uint _active_tournament_eventid = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"active_tournament_eventid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint active_tournament_eventid
    {
      get { return _active_tournament_eventid; }
      set { _active_tournament_eventid = value; }
    }

    private uint _active_survey_id = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"active_survey_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint active_survey_id
    {
      get { return _active_survey_id; }
      set { _active_survey_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OperationalStatisticDescription")]
  public partial class OperationalStatisticDescription : global::ProtoBuf.IExtensible
  {
    public OperationalStatisticDescription() {}
    

    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private uint _idkey = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"idkey", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint idkey
    {
      get { return _idkey; }
      set { _idkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OperationalStatisticElement")]
  public partial class OperationalStatisticElement : global::ProtoBuf.IExtensible
  {
    public OperationalStatisticElement() {}
    

    private uint _idkey = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"idkey", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint idkey
    {
      get { return _idkey; }
      set { _idkey = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _values = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"values", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> values
    {
      get { return _values; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OperationalStatisticsPacket")]
  public partial class OperationalStatisticsPacket : global::ProtoBuf.IExtensible
  {
    public OperationalStatisticsPacket() {}
    

    private int _packetid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"packetid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int packetid
    {
      get { return _packetid; }
      set { _packetid = value; }
    }

    private int _mstimestamp = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mstimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mstimestamp
    {
      get { return _mstimestamp; }
      set { _mstimestamp = value; }
    }
    private readonly global::System.Collections.Generic.List<OperationalStatisticElement> _values = new global::System.Collections.Generic.List<OperationalStatisticElement>();
    [global::ProtoBuf.ProtoMember(3, Name=@"values", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OperationalStatisticElement> values
    {
      get { return _values; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerRankingInfo")]
  public partial class PlayerRankingInfo : global::ProtoBuf.IExtensible
  {
    public PlayerRankingInfo() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _rank_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rank_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rank_id
    {
      get { return _rank_id; }
      set { _rank_id = value; }
    }

    private uint _wins = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"wins", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint wins
    {
      get { return _wins; }
      set { _wins = value; }
    }

    private float _rank_change = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rank_change", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float rank_change
    {
      get { return _rank_change; }
      set { _rank_change = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerCommendationInfo")]
  public partial class PlayerCommendationInfo : global::ProtoBuf.IExtensible
  {
    public PlayerCommendationInfo() {}
    

    private uint _cmd_friendly = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cmd_friendly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cmd_friendly
    {
      get { return _cmd_friendly; }
      set { _cmd_friendly = value; }
    }

    private uint _cmd_teaching = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmd_teaching", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cmd_teaching
    {
      get { return _cmd_teaching; }
      set { _cmd_teaching = value; }
    }

    private uint _cmd_leader = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cmd_leader", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cmd_leader
    {
      get { return _cmd_leader; }
      set { _cmd_leader = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerMedalsInfo")]
  public partial class PlayerMedalsInfo : global::ProtoBuf.IExtensible
  {
    public PlayerMedalsInfo() {}
    

    private uint _medal_team = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"medal_team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint medal_team
    {
      get { return _medal_team; }
      set { _medal_team = value; }
    }

    private uint _medal_combat = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"medal_combat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint medal_combat
    {
      get { return _medal_combat; }
      set { _medal_combat = value; }
    }

    private uint _medal_weapon = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"medal_weapon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint medal_weapon
    {
      get { return _medal_weapon; }
      set { _medal_weapon = value; }
    }

    private uint _medal_global = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"medal_global", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint medal_global
    {
      get { return _medal_global; }
      set { _medal_global = value; }
    }

    private uint _medal_arms = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"medal_arms", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint medal_arms
    {
      get { return _medal_arms; }
      set { _medal_arms = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _display_items_defidx = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"display_items_defidx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> display_items_defidx
    {
      get { return _display_items_defidx; }
    }
  

    private uint _featured_display_item_defidx = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"featured_display_item_defidx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint featured_display_item_defidx
    {
      get { return _featured_display_item_defidx; }
      set { _featured_display_item_defidx = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountActivity")]
  public partial class AccountActivity : global::ProtoBuf.IExtensible
  {
    public AccountActivity() {}
    

    private uint _activity = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint activity
    {
      get { return _activity; }
      set { _activity = value; }
    }

    private uint _mode = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mode
    {
      get { return _mode; }
      set { _mode = value; }
    }

    private uint _map = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"map", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint map
    {
      get { return _map; }
      set { _map = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TournamentMatchSetup")]
  public partial class TournamentMatchSetup : global::ProtoBuf.IExtensible
  {
    public TournamentMatchSetup() {}
    

    private int _event_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_id
    {
      get { return _event_id; }
      set { _event_id = value; }
    }

    private int _team_id_ct = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"team_id_ct", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_ct
    {
      get { return _team_id_ct; }
      set { _team_id_ct = value; }
    }

    private int _team_id_t = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"team_id_t", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_t
    {
      get { return _team_id_t; }
      set { _team_id_t = value; }
    }

    private int _event_stage_id = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"event_stage_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_stage_id
    {
      get { return _event_stage_id; }
      set { _event_stage_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerHltvInfo")]
  public partial class ServerHltvInfo : global::ProtoBuf.IExtensible
  {
    public ServerHltvInfo() {}
    

    private uint _tv_udp_port = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tv_udp_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_udp_port
    {
      get { return _tv_udp_port; }
      set { _tv_udp_port = value; }
    }

    private ulong _tv_watch_key = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tv_watch_key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong tv_watch_key
    {
      get { return _tv_watch_key; }
      set { _tv_watch_key = value; }
    }

    private uint _tv_slots = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tv_slots", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_slots
    {
      get { return _tv_slots; }
      set { _tv_slots = value; }
    }

    private uint _tv_clients = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"tv_clients", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_clients
    {
      get { return _tv_clients; }
      set { _tv_clients = value; }
    }

    private uint _tv_proxies = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tv_proxies", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_proxies
    {
      get { return _tv_proxies; }
      set { _tv_proxies = value; }
    }

    private uint _tv_time = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tv_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_time
    {
      get { return _tv_time; }
      set { _tv_time = value; }
    }

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }

    private string _game_mapgroup = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"game_mapgroup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_mapgroup
    {
      get { return _game_mapgroup; }
      set { _game_mapgroup = value; }
    }

    private string _game_map = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"game_map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_map
    {
      get { return _game_map; }
      set { _game_map = value; }
    }

    private ulong _tv_master_steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"tv_master_steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong tv_master_steamid
    {
      get { return _tv_master_steamid; }
      set { _tv_master_steamid = value; }
    }

    private uint _tv_local_slots = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"tv_local_slots", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_local_slots
    {
      get { return _tv_local_slots; }
      set { _tv_local_slots = value; }
    }

    private uint _tv_local_clients = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"tv_local_clients", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_local_clients
    {
      get { return _tv_local_clients; }
      set { _tv_local_clients = value; }
    }

    private uint _tv_local_proxies = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"tv_local_proxies", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_local_proxies
    {
      get { return _tv_local_proxies; }
      set { _tv_local_proxies = value; }
    }

    private uint _tv_relay_slots = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"tv_relay_slots", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_relay_slots
    {
      get { return _tv_relay_slots; }
      set { _tv_relay_slots = value; }
    }

    private uint _tv_relay_clients = default(uint);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"tv_relay_clients", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_relay_clients
    {
      get { return _tv_relay_clients; }
      set { _tv_relay_clients = value; }
    }

    private uint _tv_relay_proxies = default(uint);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"tv_relay_proxies", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_relay_proxies
    {
      get { return _tv_relay_proxies; }
      set { _tv_relay_proxies = value; }
    }

    private uint _tv_relay_address = default(uint);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"tv_relay_address", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_relay_address
    {
      get { return _tv_relay_address; }
      set { _tv_relay_address = value; }
    }

    private uint _tv_relay_port = default(uint);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"tv_relay_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_relay_port
    {
      get { return _tv_relay_port; }
      set { _tv_relay_port = value; }
    }

    private ulong _tv_relay_steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"tv_relay_steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong tv_relay_steamid
    {
      get { return _tv_relay_steamid; }
      set { _tv_relay_steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IpAddressMask")]
  public partial class IpAddressMask : global::ProtoBuf.IExtensible
  {
    public IpAddressMask() {}
    

    private uint _a = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"a", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint a
    {
      get { return _a; }
      set { _a = value; }
    }

    private uint _b = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"b", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint b
    {
      get { return _b; }
      set { _b = value; }
    }

    private uint _c = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"c", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint c
    {
      get { return _c; }
      set { _c = value; }
    }

    private uint _d = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"d", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint d
    {
      get { return _d; }
      set { _d = value; }
    }

    private uint _bits = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"bits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint bits
    {
      get { return _bits; }
      set { _bits = value; }
    }

    private uint _token = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"XpProgressData")]
  public partial class XpProgressData : global::ProtoBuf.IExtensible
  {
    public XpProgressData() {}
    

    private uint _xp_points = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"xp_points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint xp_points
    {
      get { return _xp_points; }
      set { _xp_points = value; }
    }

    private int _xp_category = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"xp_category", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int xp_category
    {
      get { return _xp_category; }
      set { _xp_category = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MatchEndItemUpdates")]
  public partial class MatchEndItemUpdates : global::ProtoBuf.IExtensible
  {
    public MatchEndItemUpdates() {}
    

    private ulong _item_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong item_id
    {
      get { return _item_id; }
      set { _item_id = value; }
    }

    private uint _item_attr_defidx = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"item_attr_defidx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint item_attr_defidx
    {
      get { return _item_attr_defidx; }
      set { _item_attr_defidx = value; }
    }

    private uint _item_attr_delta_value = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"item_attr_delta_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint item_attr_delta_value
    {
      get { return _item_attr_delta_value; }
      set { _item_attr_delta_value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScoreLeaderboardData")]
  public partial class ScoreLeaderboardData : global::ProtoBuf.IExtensible
  {
    public ScoreLeaderboardData() {}
    

    private ulong _quest_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"quest_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong quest_id
    {
      get { return _quest_id; }
      set { _quest_id = value; }
    }

    private uint _score = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint score
    {
      get { return _score; }
      set { _score = value; }
    }
    private readonly global::System.Collections.Generic.List<ScoreLeaderboardData.AccountEntries> _accountentries = new global::System.Collections.Generic.List<ScoreLeaderboardData.AccountEntries>();
    [global::ProtoBuf.ProtoMember(3, Name=@"accountentries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ScoreLeaderboardData.AccountEntries> accountentries
    {
      get { return _accountentries; }
    }
  
    private readonly global::System.Collections.Generic.List<ScoreLeaderboardData.Entry> _matchentries = new global::System.Collections.Generic.List<ScoreLeaderboardData.Entry>();
    [global::ProtoBuf.ProtoMember(5, Name=@"matchentries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ScoreLeaderboardData.Entry> matchentries
    {
      get { return _matchentries; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Entry")]
  public partial class Entry : global::ProtoBuf.IExtensible
  {
    public Entry() {}
    

    private uint _tag = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tag
    {
      get { return _tag; }
      set { _tag = value; }
    }

    private uint _val = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint val
    {
      get { return _val; }
      set { _val = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountEntries")]
  public partial class AccountEntries : global::ProtoBuf.IExtensible
  {
    public AccountEntries() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private readonly global::System.Collections.Generic.List<ScoreLeaderboardData.Entry> _entries = new global::System.Collections.Generic.List<ScoreLeaderboardData.Entry>();
    [global::ProtoBuf.ProtoMember(2, Name=@"entries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ScoreLeaderboardData.Entry> entries
    {
      get { return _entries; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerQuestData")]
  public partial class PlayerQuestData : global::ProtoBuf.IExtensible
  {
    public PlayerQuestData() {}
    

    private uint _quester_account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"quester_account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quester_account_id
    {
      get { return _quester_account_id; }
      set { _quester_account_id = value; }
    }
    private readonly global::System.Collections.Generic.List<PlayerQuestData.QuestItemData> _quest_item_data = new global::System.Collections.Generic.List<PlayerQuestData.QuestItemData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"quest_item_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerQuestData.QuestItemData> quest_item_data
    {
      get { return _quest_item_data; }
    }
  
    private readonly global::System.Collections.Generic.List<XpProgressData> _xp_progress_data = new global::System.Collections.Generic.List<XpProgressData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"xp_progress_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<XpProgressData> xp_progress_data
    {
      get { return _xp_progress_data; }
    }
  

    private uint _time_played = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"time_played", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time_played
    {
      get { return _time_played; }
      set { _time_played = value; }
    }

    private uint _mm_game_mode = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"mm_game_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mm_game_mode
    {
      get { return _mm_game_mode; }
      set { _mm_game_mode = value; }
    }
    private readonly global::System.Collections.Generic.List<MatchEndItemUpdates> _item_updates = new global::System.Collections.Generic.List<MatchEndItemUpdates>();
    [global::ProtoBuf.ProtoMember(6, Name=@"item_updates", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<MatchEndItemUpdates> item_updates
    {
      get { return _item_updates; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QuestItemData")]
  public partial class QuestItemData : global::ProtoBuf.IExtensible
  {
    public QuestItemData() {}
    

    private ulong _quest_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"quest_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong quest_id
    {
      get { return _quest_id; }
      set { _quest_id = value; }
    }

    private int _quest_normal_points_earned = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"quest_normal_points_earned", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int quest_normal_points_earned
    {
      get { return _quest_normal_points_earned; }
      set { _quest_normal_points_earned = value; }
    }

    private int _quest_bonus_points_earned = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"quest_bonus_points_earned", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int quest_bonus_points_earned
    {
      get { return _quest_bonus_points_earned; }
      set { _quest_bonus_points_earned = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGC_ServerQuestUpdateData")]
  public partial class CMsgGC_ServerQuestUpdateData : global::ProtoBuf.IExtensible
  {
    public CMsgGC_ServerQuestUpdateData() {}
    
    private readonly global::System.Collections.Generic.List<PlayerQuestData> _player_quest_data = new global::System.Collections.Generic.List<PlayerQuestData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"player_quest_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerQuestData> player_quest_data
    {
      get { return _player_quest_data; }
    }
  

    private byte[] _binary_data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"binary_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] binary_data
    {
      get { return _binary_data; }
      set { _binary_data = value; }
    }

    private uint _mm_game_mode = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"mm_game_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mm_game_mode
    {
      get { return _mm_game_mode; }
      set { _mm_game_mode = value; }
    }

    private ScoreLeaderboardData _missionlbsdata = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"missionlbsdata", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ScoreLeaderboardData missionlbsdata
    {
      get { return _missionlbsdata; }
      set { _missionlbsdata = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGCOperationalStats")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGCOperationalStats : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGCOperationalStats() {}
    

    private int _packetid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"packetid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int packetid
    {
      get { return _packetid; }
      set { _packetid = value; }
    }
    private readonly global::System.Collections.Generic.List<OperationalStatisticDescription> _namekeys = new global::System.Collections.Generic.List<OperationalStatisticDescription>();
    [global::ProtoBuf.ProtoMember(2, Name=@"namekeys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OperationalStatisticDescription> namekeys
    {
      get { return _namekeys; }
    }
  
    private readonly global::System.Collections.Generic.List<OperationalStatisticsPacket> _packets = new global::System.Collections.Generic.List<OperationalStatisticsPacket>();
    [global::ProtoBuf.ProtoMember(3, Name=@"packets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OperationalStatisticsPacket> packets
    {
      get { return _packets; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm() {}
    

    private uint _token = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint token
    {
      get { return _token; }
      set { _token = value; }
    }

    private uint _stamp = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint stamp
    {
      get { return _stamp; }
      set { _stamp = value; }
    }

    private ulong _exchange = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exchange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong exchange
    {
      get { return _exchange; }
      set { _exchange = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_GC2ServerReservationUpdate")]
  public partial class CMsgGCCStrike15_v2_GC2ServerReservationUpdate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_GC2ServerReservationUpdate() {}
    

    private uint _viewers_external_total = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"viewers_external_total", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint viewers_external_total
    {
      get { return _viewers_external_total; }
      set { _viewers_external_total = value; }
    }

    private uint _viewers_external_steam = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"viewers_external_steam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint viewers_external_steam
    {
      get { return _viewers_external_steam; }
      set { _viewers_external_steam = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingStart")]
  public partial class CMsgGCCStrike15_v2_MatchmakingStart : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingStart() {}
    
    private readonly global::System.Collections.Generic.List<uint> _account_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"account_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> account_ids
    {
      get { return _account_ids; }
    }
  

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }

    private string _ticket_data = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ticket_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ticket_data
    {
      get { return _ticket_data; }
      set { _ticket_data = value; }
    }

    private uint _client_version = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"client_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client_version
    {
      get { return _client_version; }
      set { _client_version = value; }
    }

    private TournamentMatchSetup _tournament_match = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tournament_match", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TournamentMatchSetup tournament_match
    {
      get { return _tournament_match; }
      set { _tournament_match = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingStop")]
  public partial class CMsgGCCStrike15_v2_MatchmakingStop : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingStop() {}
    

    private int _abandon = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"abandon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int abandon
    {
      get { return _abandon; }
      set { _abandon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingClient2ServerPing")]
  public partial class CMsgGCCStrike15_v2_MatchmakingClient2ServerPing : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingClient2ServerPing() {}
    
    private readonly global::System.Collections.Generic.List<GameServerPing> _gameserverpings = new global::System.Collections.Generic.List<GameServerPing>();
    [global::ProtoBuf.ProtoMember(1, Name=@"gameserverpings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<GameServerPing> gameserverpings
    {
      get { return _gameserverpings; }
    }
  

    private int _offset_index = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"offset_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int offset_index
    {
      get { return _offset_index; }
      set { _offset_index = value; }
    }

    private int _final_batch = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"final_batch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int final_batch
    {
      get { return _final_batch; }
      set { _final_batch = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate() {}
    

    private int _matchmaking = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"matchmaking", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int matchmaking
    {
      get { return _matchmaking; }
      set { _matchmaking = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _waiting_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"waiting_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> waiting_account_id_sessions
    {
      get { return _waiting_account_id_sessions; }
    }
  

    private string _error = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _ongoingmatch_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"ongoingmatch_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> ongoingmatch_account_id_sessions
    {
      get { return _ongoingmatch_account_id_sessions; }
    }
  

    private GlobalStatistics _global_stats = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"global_stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GlobalStatistics global_stats
    {
      get { return _global_stats; }
      set { _global_stats = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _failping_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"failping_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> failping_account_id_sessions
    {
      get { return _failping_account_id_sessions; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _penalty_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"penalty_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> penalty_account_id_sessions
    {
      get { return _penalty_account_id_sessions; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _failready_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"failready_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> failready_account_id_sessions
    {
      get { return _failready_account_id_sessions; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _vacbanned_account_id_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(11, Name=@"vacbanned_account_id_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> vacbanned_account_id_sessions
    {
      get { return _vacbanned_account_id_sessions; }
    }
  

    private IpAddressMask _server_ipaddress_mask = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"server_ipaddress_mask", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public IpAddressMask server_ipaddress_mask
    {
      get { return _server_ipaddress_mask; }
      set { _server_ipaddress_mask = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate.Note> _notes = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate.Note>();
    [global::ProtoBuf.ProtoMember(13, Name=@"notes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate.Note> notes
    {
      get { return _notes; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _penalty_account_id_sessions_green = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(14, Name=@"penalty_account_id_sessions_green", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> penalty_account_id_sessions_green
    {
      get { return _penalty_account_id_sessions_green; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _insufficientlevel_sessions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(15, Name=@"insufficientlevel_sessions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> insufficientlevel_sessions
    {
      get { return _insufficientlevel_sessions; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Note")]
  public partial class Note : global::ProtoBuf.IExtensible
  {
    public Note() {}
    

    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private int _region_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"region_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int region_id
    {
      get { return _region_id; }
      set { _region_id = value; }
    }

    private float _region_r = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"region_r", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float region_r
    {
      get { return _region_r; }
      set { _region_r = value; }
    }

    private float _distance = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"distance", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float distance
    {
      get { return _distance; }
      set { _distance = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_TournamentMatchDraft")]
  public partial class CDataGCCStrike15_v2_TournamentMatchDraft : global::ProtoBuf.IExtensible
  {
    public CDataGCCStrike15_v2_TournamentMatchDraft() {}
    

    private int _event_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_id
    {
      get { return _event_id; }
      set { _event_id = value; }
    }

    private int _event_stage_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"event_stage_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_stage_id
    {
      get { return _event_stage_id; }
      set { _event_stage_id = value; }
    }

    private int _team_id_0 = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"team_id_0", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_0
    {
      get { return _team_id_0; }
      set { _team_id_0 = value; }
    }

    private int _team_id_1 = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"team_id_1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_1
    {
      get { return _team_id_1; }
      set { _team_id_1 = value; }
    }

    private int _maps_count = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"maps_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int maps_count
    {
      get { return _maps_count; }
      set { _maps_count = value; }
    }

    private int _maps_current = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"maps_current", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int maps_current
    {
      get { return _maps_current; }
      set { _maps_current = value; }
    }

    private int _team_id_start = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"team_id_start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_start
    {
      get { return _team_id_start; }
      set { _team_id_start = value; }
    }

    private int _team_id_veto1 = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"team_id_veto1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_veto1
    {
      get { return _team_id_veto1; }
      set { _team_id_veto1 = value; }
    }

    private int _team_id_pickn = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"team_id_pickn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_pickn
    {
      get { return _team_id_pickn; }
      set { _team_id_pickn = value; }
    }
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentMatchDraft.Entry> _drafts = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentMatchDraft.Entry>();
    [global::ProtoBuf.ProtoMember(10, Name=@"drafts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentMatchDraft.Entry> drafts
    {
      get { return _drafts; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Entry")]
  public partial class Entry : global::ProtoBuf.IExtensible
  {
    public Entry() {}
    

    private int _mapid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }

    private int _team_id_ct = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"team_id_ct", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id_ct
    {
      get { return _team_id_ct; }
      set { _team_id_ct = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPreMatchInfoData")]
  public partial class CPreMatchInfoData : global::ProtoBuf.IExtensible
  {
    public CPreMatchInfoData() {}
    

    private int _predictions_pct = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"predictions_pct", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int predictions_pct
    {
      get { return _predictions_pct; }
      set { _predictions_pct = value; }
    }

    private CDataGCCStrike15_v2_TournamentMatchDraft _draft = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"draft", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDataGCCStrike15_v2_TournamentMatchDraft draft
    {
      get { return _draft; }
      set { _draft = value; }
    }
    private readonly global::System.Collections.Generic.List<CPreMatchInfoData.TeamStats> _stats = new global::System.Collections.Generic.List<CPreMatchInfoData.TeamStats>();
    [global::ProtoBuf.ProtoMember(5, Name=@"stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPreMatchInfoData.TeamStats> stats
    {
      get { return _stats; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamStats")]
  public partial class TeamStats : global::ProtoBuf.IExtensible
  {
    public TeamStats() {}
    

    private int _match_info_idxtxt = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"match_info_idxtxt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int match_info_idxtxt
    {
      get { return _match_info_idxtxt; }
      set { _match_info_idxtxt = value; }
    }

    private string _match_info_txt = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"match_info_txt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string match_info_txt
    {
      get { return _match_info_txt; }
      set { _match_info_txt = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _match_info_teams = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"match_info_teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> match_info_teams
    {
      get { return _match_info_teams; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve() {}
    
    private readonly global::System.Collections.Generic.List<uint> _account_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"account_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> account_ids
    {
      get { return _account_ids; }
    }
  

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }

    private uint _server_version = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"server_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_version
    {
      get { return _server_version; }
      set { _server_version = value; }
    }
    private readonly global::System.Collections.Generic.List<PlayerRankingInfo> _rankings = new global::System.Collections.Generic.List<PlayerRankingInfo>();
    [global::ProtoBuf.ProtoMember(5, Name=@"rankings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerRankingInfo> rankings
    {
      get { return _rankings; }
    }
  

    private ulong _encryption_key = default(ulong);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"encryption_key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong encryption_key
    {
      get { return _encryption_key; }
      set { _encryption_key = value; }
    }

    private ulong _encryption_key_pub = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"encryption_key_pub", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong encryption_key_pub
    {
      get { return _encryption_key_pub; }
      set { _encryption_key_pub = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _party_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"party_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> party_ids
    {
      get { return _party_ids; }
    }
  
    private readonly global::System.Collections.Generic.List<IpAddressMask> _whitelist = new global::System.Collections.Generic.List<IpAddressMask>();
    [global::ProtoBuf.ProtoMember(9, Name=@"whitelist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<IpAddressMask> whitelist
    {
      get { return _whitelist; }
    }
  

    private ulong _tv_master_steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"tv_master_steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong tv_master_steamid
    {
      get { return _tv_master_steamid; }
      set { _tv_master_steamid = value; }
    }

    private TournamentEvent _tournament_event = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"tournament_event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TournamentEvent tournament_event
    {
      get { return _tournament_event; }
      set { _tournament_event = value; }
    }
    private readonly global::System.Collections.Generic.List<TournamentTeam> _tournament_teams = new global::System.Collections.Generic.List<TournamentTeam>();
    [global::ProtoBuf.ProtoMember(12, Name=@"tournament_teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentTeam> tournament_teams
    {
      get { return _tournament_teams; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _tournament_casters_account_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(13, Name=@"tournament_casters_account_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> tournament_casters_account_ids
    {
      get { return _tournament_casters_account_ids; }
    }
  

    private ulong _tv_relay_steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"tv_relay_steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong tv_relay_steamid
    {
      get { return _tv_relay_steamid; }
      set { _tv_relay_steamid = value; }
    }

    private CPreMatchInfoData _pre_match_data = null;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"pre_match_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CPreMatchInfoData pre_match_data
    {
      get { return _pre_match_data; }
      set { _pre_match_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingServerReservationResponse")]
  public partial class CMsgGCCStrike15_v2_MatchmakingServerReservationResponse : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingServerReservationResponse() {}
    

    private ulong _reservationid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"reservationid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong reservationid
    {
      get { return _reservationid; }
      set { _reservationid = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve _reservation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reservation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve reservation
    {
      get { return _reservation; }
      set { _reservation = value; }
    }

    private string _map = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map
    {
      get { return _map; }
      set { _map = value; }
    }

    private ulong _gc_reservation_sent = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gc_reservation_sent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong gc_reservation_sent
    {
      get { return _gc_reservation_sent; }
      set { _gc_reservation_sent = value; }
    }

    private uint _server_version = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"server_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_version
    {
      get { return _server_version; }
      set { _server_version = value; }
    }

    private ServerHltvInfo _tv_info = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tv_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ServerHltvInfo tv_info
    {
      get { return _tv_info; }
      set { _tv_info = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _reward_player_accounts = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"reward_player_accounts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> reward_player_accounts
    {
      get { return _reward_player_accounts; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _idle_player_accounts = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"idle_player_accounts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> idle_player_accounts
    {
      get { return _idle_player_accounts; }
    }
  

    private uint _reward_item_attr_def_idx = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"reward_item_attr_def_idx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reward_item_attr_def_idx
    {
      get { return _reward_item_attr_def_idx; }
      set { _reward_item_attr_def_idx = value; }
    }

    private uint _reward_item_attr_value = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"reward_item_attr_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reward_item_attr_value
    {
      get { return _reward_item_attr_value; }
      set { _reward_item_attr_value = value; }
    }

    private uint _reward_item_attr_reward_idx = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"reward_item_attr_reward_idx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reward_item_attr_reward_idx
    {
      get { return _reward_item_attr_reward_idx; }
      set { _reward_item_attr_reward_idx = value; }
    }

    private uint _reward_drop_list = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"reward_drop_list", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reward_drop_list
    {
      get { return _reward_drop_list; }
      set { _reward_drop_list = value; }
    }

    private string _tournament_tag = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"tournament_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tournament_tag
    {
      get { return _tournament_tag; }
      set { _tournament_tag = value; }
    }

    private uint _steamdatagram_port = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"steamdatagram_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint steamdatagram_port
    {
      get { return _steamdatagram_port; }
      set { _steamdatagram_port = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve() {}
    

    private ulong _serverid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serverid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong serverid
    {
      get { return _serverid; }
      set { _serverid = value; }
    }

    private string _server_address = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"server_address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string server_address
    {
      get { return _server_address; }
      set { _server_address = value; }
    }

    private uint _legacy_serverip = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"legacy_serverip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint legacy_serverip
    {
      get { return _legacy_serverip; }
      set { _legacy_serverip = value; }
    }

    private uint _legacy_serverport = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"legacy_serverport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint legacy_serverport
    {
      get { return _legacy_serverport; }
      set { _legacy_serverport = value; }
    }

    private ulong _reservationid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"reservationid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong reservationid
    {
      get { return _reservationid; }
      set { _reservationid = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve _reservation = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"reservation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve reservation
    {
      get { return _reservation; }
      set { _reservation = value; }
    }

    private string _map = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map
    {
      get { return _map; }
      set { _map = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingServerRoundStats")]
  public partial class CMsgGCCStrike15_v2_MatchmakingServerRoundStats : global::ProtoBuf.IExtensible//123
  {
    public CMsgGCCStrike15_v2_MatchmakingServerRoundStats() {}
    

    private ulong _reservationid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"reservationid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong reservationid
    {
      get { return _reservationid; }
      set { _reservationid = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve _reservation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reservation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve reservation
    {
      get { return _reservation; }
      set { _reservation = value; }
    }

    private string _map = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map
    {
      get { return _map; }
      set { _map = value; }
    }

    private int _round = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"round", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int round
    {
      get { return _round; }
      set { _round = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _kills = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"kills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> kills
    {
      get { return _kills; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _assists = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"assists", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> assists
    {
      get { return _assists; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _deaths = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(7, Name=@"deaths", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> deaths
    {
      get { return _deaths; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _scores = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(8, Name=@"scores", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> scores
    {
      get { return _scores; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _pings = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(9, Name=@"pings", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> pings
    {
      get { return _pings; }
    }
  

    private int _round_result = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"round_result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int round_result
    {
      get { return _round_result; }
      set { _round_result = value; }
    }

    private int _match_result = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"match_result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int match_result
    {
      get { return _match_result; }
      set { _match_result = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _team_scores = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(12, Name=@"team_scores", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> team_scores
    {
      get { return _team_scores; }
    }
  

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm _confirm = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"confirm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm confirm
    {
      get { return _confirm; }
      set { _confirm = value; }
    }

    private int _reservation_stage = default(int);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"reservation_stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int reservation_stage
    {
      get { return _reservation_stage; }
      set { _reservation_stage = value; }
    }

    private int _match_duration = default(int);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"match_duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int match_duration
    {
      get { return _match_duration; }
      set { _match_duration = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _enemy_kills = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(16, Name=@"enemy_kills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_kills
    {
      get { return _enemy_kills; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _enemy_headshots = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(17, Name=@"enemy_headshots", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_headshots
    {
      get { return _enemy_headshots; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _enemy_3ks = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(18, Name=@"enemy_3ks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_3ks
    {
      get { return _enemy_3ks; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _enemy_4ks = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(19, Name=@"enemy_4ks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_4ks
    {
      get { return _enemy_4ks; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _enemy_5ks = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(20, Name=@"enemy_5ks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_5ks
    {
      get { return _enemy_5ks; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _mvps = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(21, Name=@"mvps", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> mvps
    {
      get { return _mvps; }
    }
  

    private uint _spectators_count = default(uint);
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"spectators_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint spectators_count
    {
      get { return _spectators_count; }
      set { _spectators_count = value; }
    }

    private uint _spectators_count_tv = default(uint);
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"spectators_count_tv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint spectators_count_tv
    {
      get { return _spectators_count_tv; }
      set { _spectators_count_tv = value; }
    }

    private uint _spectators_count_lnk = default(uint);
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"spectators_count_lnk", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint spectators_count_lnk
    {
      get { return _spectators_count_lnk; }
      set { _spectators_count_lnk = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _enemy_kills_agg = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(25, Name=@"enemy_kills_agg", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> enemy_kills_agg
    {
      get { return _enemy_kills_agg; }
    }
  

    private CMsgGCCStrike15_v2_MatchmakingServerRoundStats.DropInfo _drop_info = null;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"drop_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingServerRoundStats.DropInfo drop_info
    {
      get { return _drop_info; }
      set { _drop_info = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DropInfo")]
  public partial class DropInfo : global::ProtoBuf.IExtensible
  {
    public DropInfo() {}
    

    private uint _account_mvp = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_mvp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_mvp
    {
      get { return _account_mvp; }
      set { _account_mvp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingServerMatchEnd")]
  public partial class CMsgGCCStrike15_v2_MatchmakingServerMatchEnd : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingServerMatchEnd() {}
    

    private CMsgGCCStrike15_v2_MatchmakingServerRoundStats _stats = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingServerRoundStats stats
    {
      get { return _stats; }
      set { _stats = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm _confirm = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"confirm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm confirm
    {
      get { return _confirm; }
      set { _confirm = value; }
    }

    private ulong _rematch = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rematch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong rematch
    {
      get { return _rematch; }
      set { _rematch = value; }
    }

    private uint _replay_token = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"replay_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint replay_token
    {
      get { return _replay_token; }
      set { _replay_token = value; }
    }

    private uint _replay_cluster_id = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"replay_cluster_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint replay_cluster_id
    {
      get { return _replay_cluster_id; }
      set { _replay_cluster_id = value; }
    }

    private bool _aborted_match = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"aborted_match", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool aborted_match
    {
      get { return _aborted_match; }
      set { _aborted_match = value; }
    }

    private CMsgGC_ServerQuestUpdateData _match_end_quest_data = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"match_end_quest_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGC_ServerQuestUpdateData match_end_quest_data
    {
      get { return _match_end_quest_data; }
      set { _match_end_quest_data = value; }
    }

    private uint _server_version = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"server_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_version
    {
      get { return _server_version; }
      set { _server_version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingClient2GCHello")]
  public partial class CMsgGCCStrike15_v2_MatchmakingClient2GCHello : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingClient2GCHello() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ClientHello")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ClientHello : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientHello() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve _ongoingmatch = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ongoingmatch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve ongoingmatch
    {
      get { return _ongoingmatch; }
      set { _ongoingmatch = value; }
    }

    private GlobalStatistics _global_stats = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"global_stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GlobalStatistics global_stats
    {
      get { return _global_stats; }
      set { _global_stats = value; }
    }

    private uint _penalty_seconds = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"penalty_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint penalty_seconds
    {
      get { return _penalty_seconds; }
      set { _penalty_seconds = value; }
    }

    private uint _penalty_reason = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"penalty_reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint penalty_reason
    {
      get { return _penalty_reason; }
      set { _penalty_reason = value; }
    }

    private int _vac_banned = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vac_banned", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vac_banned
    {
      get { return _vac_banned; }
      set { _vac_banned = value; }
    }

    private PlayerRankingInfo _ranking = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ranking", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerRankingInfo ranking
    {
      get { return _ranking; }
      set { _ranking = value; }
    }

    private PlayerCommendationInfo _commendation = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"commendation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerCommendationInfo commendation
    {
      get { return _commendation; }
      set { _commendation = value; }
    }

    private PlayerMedalsInfo _medals = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"medals", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerMedalsInfo medals
    {
      get { return _medals; }
      set { _medals = value; }
    }

    private TournamentEvent _my_current_event = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"my_current_event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TournamentEvent my_current_event
    {
      get { return _my_current_event; }
      set { _my_current_event = value; }
    }
    private readonly global::System.Collections.Generic.List<TournamentTeam> _my_current_event_teams = new global::System.Collections.Generic.List<TournamentTeam>();
    [global::ProtoBuf.ProtoMember(11, Name=@"my_current_event_teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentTeam> my_current_event_teams
    {
      get { return _my_current_event_teams; }
    }
  

    private TournamentTeam _my_current_team = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"my_current_team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TournamentTeam my_current_team
    {
      get { return _my_current_team; }
      set { _my_current_team = value; }
    }
    private readonly global::System.Collections.Generic.List<TournamentEvent> _my_current_event_stages = new global::System.Collections.Generic.List<TournamentEvent>();
    [global::ProtoBuf.ProtoMember(13, Name=@"my_current_event_stages", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentEvent> my_current_event_stages
    {
      get { return _my_current_event_stages; }
    }
  

    private uint _survey_vote = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"survey_vote", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint survey_vote
    {
      get { return _survey_vote; }
      set { _survey_vote = value; }
    }

    private AccountActivity _activity = null;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public AccountActivity activity
    {
      get { return _activity; }
      set { _activity = value; }
    }

    private int _player_level = default(int);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"player_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_level
    {
      get { return _player_level; }
      set { _player_level = value; }
    }

    private int _player_cur_xp = default(int);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"player_cur_xp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_cur_xp
    {
      get { return _player_cur_xp; }
      set { _player_cur_xp = value; }
    }

    private int _player_xp_bonus_flags = default(int);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"player_xp_bonus_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_xp_bonus_flags
    {
      get { return _player_xp_bonus_flags; }
      set { _player_xp_bonus_flags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_AccountPrivacySettings")]
  public partial class CMsgGCCStrike15_v2_AccountPrivacySettings : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_AccountPrivacySettings() {}
    
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_AccountPrivacySettings.Setting> _settings = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_AccountPrivacySettings.Setting>();
    [global::ProtoBuf.ProtoMember(1, Name=@"settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_AccountPrivacySettings.Setting> settings
    {
      get { return _settings; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Setting")]
  public partial class Setting : global::ProtoBuf.IExtensible
  {
    public Setting() {}
    

    private uint _setting_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"setting_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint setting_type
    {
      get { return _setting_type; }
      set { _setting_type = value; }
    }

    private uint _setting_value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"setting_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint setting_value
    {
      get { return _setting_value; }
      set { _setting_value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve _abandoned_match = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"abandoned_match", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve abandoned_match
    {
      get { return _abandoned_match; }
      set { _abandoned_match = value; }
    }

    private uint _penalty_seconds = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"penalty_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint penalty_seconds
    {
      get { return _penalty_seconds; }
      set { _penalty_seconds = value; }
    }

    private uint _penalty_reason = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"penalty_reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint penalty_reason
    {
      get { return _penalty_reason; }
      set { _penalty_reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingServer2GCKick")]
  public partial class CMsgGCCStrike15_v2_MatchmakingServer2GCKick : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingServer2GCKick() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve _reservation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reservation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerReserve reservation
    {
      get { return _reservation; }
      set { _reservation = value; }
    }

    private uint _reason = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingGC2ServerRankUpdate")]
  public partial class CMsgGCCStrike15_v2_MatchmakingGC2ServerRankUpdate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingGC2ServerRankUpdate() {}
    
    private readonly global::System.Collections.Generic.List<PlayerRankingInfo> _rankings = new global::System.Collections.Generic.List<PlayerRankingInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"rankings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerRankingInfo> rankings
    {
      get { return _rankings; }
    }
  

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate")]
  public partial class CMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate() {}
    

    private string _main_post_url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"main_post_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string main_post_url
    {
      get { return _main_post_url; }
      set { _main_post_url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ServerNotificationForUserPenalty")]
  public partial class CMsgGCCStrike15_v2_ServerNotificationForUserPenalty : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ServerNotificationForUserPenalty() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _reason = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reason
    {
      get { return _reason; }
      set { _reason = value; }
    }

    private uint _seconds = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint seconds
    {
      get { return _seconds; }
      set { _seconds = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientReportPlayer")]
  public partial class CMsgGCCStrike15_v2_ClientReportPlayer : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientReportPlayer() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _rpt_aimbot = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rpt_aimbot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_aimbot
    {
      get { return _rpt_aimbot; }
      set { _rpt_aimbot = value; }
    }

    private uint _rpt_wallhack = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rpt_wallhack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_wallhack
    {
      get { return _rpt_wallhack; }
      set { _rpt_wallhack = value; }
    }

    private uint _rpt_speedhack = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rpt_speedhack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_speedhack
    {
      get { return _rpt_speedhack; }
      set { _rpt_speedhack = value; }
    }

    private uint _rpt_teamharm = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rpt_teamharm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_teamharm
    {
      get { return _rpt_teamharm; }
      set { _rpt_teamharm = value; }
    }

    private uint _rpt_textabuse = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"rpt_textabuse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_textabuse
    {
      get { return _rpt_textabuse; }
      set { _rpt_textabuse = value; }
    }

    private uint _rpt_voiceabuse = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"rpt_voiceabuse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_voiceabuse
    {
      get { return _rpt_voiceabuse; }
      set { _rpt_voiceabuse = value; }
    }

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientCommendPlayer")]
  public partial class CMsgGCCStrike15_v2_ClientCommendPlayer : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientCommendPlayer() {}
    

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }

    private PlayerCommendationInfo _commendation = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"commendation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerCommendationInfo commendation
    {
      get { return _commendation; }
      set { _commendation = value; }
    }

    private uint _tokens = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"tokens", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tokens
    {
      get { return _tokens; }
      set { _tokens = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientReportServer")]
  public partial class CMsgGCCStrike15_v2_ClientReportServer : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientReportServer() {}
    

    private uint _rpt_poorperf = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rpt_poorperf", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_poorperf
    {
      get { return _rpt_poorperf; }
      set { _rpt_poorperf = value; }
    }

    private uint _rpt_abusivemodels = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rpt_abusivemodels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_abusivemodels
    {
      get { return _rpt_abusivemodels; }
      set { _rpt_abusivemodels = value; }
    }

    private uint _rpt_badmotd = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rpt_badmotd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_badmotd
    {
      get { return _rpt_badmotd; }
      set { _rpt_badmotd = value; }
    }

    private uint _rpt_listingabuse = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rpt_listingabuse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_listingabuse
    {
      get { return _rpt_listingabuse; }
      set { _rpt_listingabuse = value; }
    }

    private uint _rpt_inventoryabuse = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rpt_inventoryabuse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_inventoryabuse
    {
      get { return _rpt_inventoryabuse; }
      set { _rpt_inventoryabuse = value; }
    }

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientReportResponse")]
  public partial class CMsgGCCStrike15_v2_ClientReportResponse : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientReportResponse() {}
    

    private ulong _confirmation_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"confirmation_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong confirmation_id
    {
      get { return _confirmation_id; }
      set { _confirmation_id = value; }
    }

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _server_ip = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"server_ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_ip
    {
      get { return _server_ip; }
      set { _server_ip = value; }
    }

    private uint _response_type = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"response_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint response_type
    {
      get { return _response_type; }
      set { _response_type = value; }
    }

    private uint _response_result = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"response_result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint response_result
    {
      get { return _response_result; }
      set { _response_result = value; }
    }

    private uint _tokens = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tokens", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tokens
    {
      get { return _tokens; }
      set { _tokens = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientRequestWatchInfoFriends")]
  public partial class CMsgGCCStrike15_v2_ClientRequestWatchInfoFriends : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientRequestWatchInfoFriends() {}
    

    private uint _request_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"request_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint request_id
    {
      get { return _request_id; }
      set { _request_id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _account_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"account_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> account_ids
    {
      get { return _account_ids; }
    }
  

    private ulong _serverid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong serverid
    {
      get { return _serverid; }
      set { _serverid = value; }
    }

    private ulong _matchid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"matchid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong matchid
    {
      get { return _matchid; }
      set { _matchid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WatchableMatchInfo")]
  public partial class WatchableMatchInfo : global::ProtoBuf.IExtensible
  {
    public WatchableMatchInfo() {}
    

    private uint _server_ip = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"server_ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_ip
    {
      get { return _server_ip; }
      set { _server_ip = value; }
    }

    private uint _tv_port = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tv_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_port
    {
      get { return _tv_port; }
      set { _tv_port = value; }
    }

    private uint _tv_spectators = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tv_spectators", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_spectators
    {
      get { return _tv_spectators; }
      set { _tv_spectators = value; }
    }

    private uint _tv_time = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"tv_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tv_time
    {
      get { return _tv_time; }
      set { _tv_time = value; }
    }

    private byte[] _tv_watch_password = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tv_watch_password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] tv_watch_password
    {
      get { return _tv_watch_password; }
      set { _tv_watch_password = value; }
    }

    private ulong _cl_decryptdata_key = default(ulong);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"cl_decryptdata_key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong cl_decryptdata_key
    {
      get { return _cl_decryptdata_key; }
      set { _cl_decryptdata_key = value; }
    }

    private ulong _cl_decryptdata_key_pub = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"cl_decryptdata_key_pub", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong cl_decryptdata_key_pub
    {
      get { return _cl_decryptdata_key_pub; }
      set { _cl_decryptdata_key_pub = value; }
    }

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }

    private string _game_mapgroup = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"game_mapgroup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_mapgroup
    {
      get { return _game_mapgroup; }
      set { _game_mapgroup = value; }
    }

    private string _game_map = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"game_map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_map
    {
      get { return _game_map; }
      set { _game_map = value; }
    }

    private ulong _server_id = default(ulong);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"server_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong server_id
    {
      get { return _server_id; }
      set { _server_id = value; }
    }

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }

    private ulong _reservation_id = default(ulong);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"reservation_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong reservation_id
    {
      get { return _reservation_id; }
      set { _reservation_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientRequestJoinFriendData")]
  public partial class CMsgGCCStrike15_v2_ClientRequestJoinFriendData : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientRequestJoinFriendData() {}
    

    private uint _version = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _join_token = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"join_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint join_token
    {
      get { return _join_token; }
      set { _join_token = value; }
    }

    private uint _join_ipp = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"join_ipp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint join_ipp
    {
      get { return _join_ipp; }
      set { _join_ipp = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve _res = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"res", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve res
    {
      get { return _res; }
      set { _res = value; }
    }

    private string _errormsg = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"errormsg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errormsg
    {
      get { return _errormsg; }
      set { _errormsg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientRequestJoinServerData")]
  public partial class CMsgGCCStrike15_v2_ClientRequestJoinServerData : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientRequestJoinServerData() {}
    

    private uint _version = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private ulong _serverid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong serverid
    {
      get { return _serverid; }
      set { _serverid = value; }
    }

    private uint _server_ip = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"server_ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_ip
    {
      get { return _server_ip; }
      set { _server_ip = value; }
    }

    private uint _server_port = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"server_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_port
    {
      get { return _server_port; }
      set { _server_port = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve _res = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"res", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingGC2ClientReserve res
    {
      get { return _res; }
      set { _res = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCstrike15_v2_ClientRequestNewMission")]
  public partial class CMsgGCCstrike15_v2_ClientRequestNewMission : global::ProtoBuf.IExtensible
  {
    public CMsgGCCstrike15_v2_ClientRequestNewMission() {}
    

    private uint _mission_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mission_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mission_id
    {
      get { return _mission_id; }
      set { _mission_id = value; }
    }

    private uint _campaign_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"campaign_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint campaign_id
    {
      get { return _campaign_id; }
      set { _campaign_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCstrike15_v2_GC2ServerNotifyXPRewarded")]
  public partial class CMsgGCCstrike15_v2_GC2ServerNotifyXPRewarded : global::ProtoBuf.IExtensible
  {
    public CMsgGCCstrike15_v2_GC2ServerNotifyXPRewarded() {}
    
    private readonly global::System.Collections.Generic.List<XpProgressData> _xp_progress_data = new global::System.Collections.Generic.List<XpProgressData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"xp_progress_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<XpProgressData> xp_progress_data
    {
      get { return _xp_progress_data; }
    }
  

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _current_xp = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"current_xp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint current_xp
    {
      get { return _current_xp; }
      set { _current_xp = value; }
    }

    private uint _current_level = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"current_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint current_level
    {
      get { return _current_level; }
      set { _current_level = value; }
    }

    private uint _upgraded_defidx = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"upgraded_defidx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint upgraded_defidx
    {
      get { return _upgraded_defidx; }
      set { _upgraded_defidx = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_WatchInfoUsers")]
  public partial class CMsgGCCStrike15_v2_WatchInfoUsers : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_WatchInfoUsers() {}
    

    private uint _request_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"request_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint request_id
    {
      get { return _request_id; }
      set { _request_id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _account_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"account_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> account_ids
    {
      get { return _account_ids; }
    }
  
    private readonly global::System.Collections.Generic.List<WatchableMatchInfo> _watchable_match_infos = new global::System.Collections.Generic.List<WatchableMatchInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"watchable_match_infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<WatchableMatchInfo> watchable_match_infos
    {
      get { return _watchable_match_infos; }
    }
  

    private uint _extended_timeout = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"extended_timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint extended_timeout
    {
      get { return _extended_timeout; }
      set { _extended_timeout = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientRequestPlayersProfile")]
  public partial class CMsgGCCStrike15_v2_ClientRequestPlayersProfile : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientRequestPlayersProfile() {}
    

    private uint _request_id__deprecated = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"request_id__deprecated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint request_id__deprecated
    {
      get { return _request_id__deprecated; }
      set { _request_id__deprecated = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _account_ids__deprecated = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"account_ids__deprecated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> account_ids__deprecated
    {
      get { return _account_ids__deprecated; }
    }
  

    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }

    private uint _request_level = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"request_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint request_level
    {
      get { return _request_level; }
      set { _request_level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_PlayersProfile")]
  public partial class CMsgGCCStrike15_v2_PlayersProfile : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_PlayersProfile() {}
    

    private uint _request_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"request_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint request_id
    {
      get { return _request_id; }
      set { _request_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientHello> _account_profiles = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientHello>();
    [global::ProtoBuf.ProtoMember(2, Name=@"account_profiles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingGC2ClientHello> account_profiles
    {
      get { return _account_profiles; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate")]
  public partial class CMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate() {}
    

    private ulong _caseid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"caseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong caseid
    {
      get { return _caseid; }
      set { _caseid = value; }
    }

    private uint _suspectid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"suspectid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint suspectid
    {
      get { return _suspectid; }
      set { _suspectid = value; }
    }

    private uint _fractionid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fractionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint fractionid
    {
      get { return _fractionid; }
      set { _fractionid = value; }
    }

    private uint _rpt_aimbot = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rpt_aimbot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_aimbot
    {
      get { return _rpt_aimbot; }
      set { _rpt_aimbot = value; }
    }

    private uint _rpt_wallhack = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"rpt_wallhack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_wallhack
    {
      get { return _rpt_wallhack; }
      set { _rpt_wallhack = value; }
    }

    private uint _rpt_speedhack = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"rpt_speedhack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_speedhack
    {
      get { return _rpt_speedhack; }
      set { _rpt_speedhack = value; }
    }

    private uint _rpt_teamharm = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"rpt_teamharm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rpt_teamharm
    {
      get { return _rpt_teamharm; }
      set { _rpt_teamharm = value; }
    }

    private uint _reason = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment")]
  public partial class CMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment() {}
    

    private ulong _caseid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"caseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong caseid
    {
      get { return _caseid; }
      set { _caseid = value; }
    }

    private string _caseurl = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"caseurl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caseurl
    {
      get { return _caseurl; }
      set { _caseurl = value; }
    }

    private uint _verdict = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"verdict", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint verdict
    {
      get { return _verdict; }
      set { _verdict = value; }
    }

    private uint _timestamp = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private uint _throttleseconds = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"throttleseconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint throttleseconds
    {
      get { return _throttleseconds; }
      set { _throttleseconds = value; }
    }

    private uint _suspectid = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"suspectid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint suspectid
    {
      get { return _suspectid; }
      set { _suspectid = value; }
    }

    private uint _fractionid = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fractionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint fractionid
    {
      get { return _fractionid; }
      set { _fractionid = value; }
    }

    private uint _numrounds = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"numrounds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint numrounds
    {
      get { return _numrounds; }
      set { _numrounds = value; }
    }

    private uint _fractionrounds = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"fractionrounds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint fractionrounds
    {
      get { return _fractionrounds; }
      set { _fractionrounds = value; }
    }

    private int _streakconvictions = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"streakconvictions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int streakconvictions
    {
      get { return _streakconvictions; }
      set { _streakconvictions = value; }
    }

    private uint _reason = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_PlayerOverwatchCaseStatus")]
  public partial class CMsgGCCStrike15_v2_PlayerOverwatchCaseStatus : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_PlayerOverwatchCaseStatus() {}
    

    private ulong _caseid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"caseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong caseid
    {
      get { return _caseid; }
      set { _caseid = value; }
    }

    private uint _statusid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"statusid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint statusid
    {
      get { return _statusid; }
      set { _statusid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CClientHeaderOverwatchEvidence")]
  public partial class CClientHeaderOverwatchEvidence : global::ProtoBuf.IExtensible
  {
    public CClientHeaderOverwatchEvidence() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private ulong _caseid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"caseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong caseid
    {
      get { return _caseid; }
      set { _caseid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_GC2ClientTextMsg")]
  public partial class CMsgGCCStrike15_v2_GC2ClientTextMsg : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_GC2ClientTextMsg() {}
    

    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }

    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }

    private byte[] _payload = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"payload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] payload
    {
      get { return _payload; }
      set { _payload = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Client2GCTextMsg")]
  public partial class CMsgGCCStrike15_v2_Client2GCTextMsg : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Client2GCTextMsg() {}
    

    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _args = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(2, Name=@"args", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> args
    {
      get { return _args; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchEndRunRewardDrops")]
  public partial class CMsgGCCStrike15_v2_MatchEndRunRewardDrops : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchEndRunRewardDrops() {}
    

    private CMsgGCCStrike15_v2_MatchmakingServerReservationResponse _serverinfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingServerReservationResponse serverinfo
    {
      get { return _serverinfo; }
      set { _serverinfo = value; }
    }

    private CMsgGC_ServerQuestUpdateData _match_end_quest_data = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"match_end_quest_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGC_ServerQuestUpdateData match_end_quest_data
    {
      get { return _match_end_quest_data; }
      set { _match_end_quest_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CEconItemPreviewDataBlock")]
  public partial class CEconItemPreviewDataBlock : global::ProtoBuf.IExtensible
  {
    public CEconItemPreviewDataBlock() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }

    private uint _defindex = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"defindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint defindex
    {
      get { return _defindex; }
      set { _defindex = value; }
    }

    private uint _paintindex = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"paintindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint paintindex
    {
      get { return _paintindex; }
      set { _paintindex = value; }
    }

    private uint _rarity = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rarity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rarity
    {
      get { return _rarity; }
      set { _rarity = value; }
    }

    private uint _quality = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quality
    {
      get { return _quality; }
      set { _quality = value; }
    }

    private uint _paintwear = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"paintwear", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint paintwear
    {
      get { return _paintwear; }
      set { _paintwear = value; }
    }

    private uint _paintseed = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"paintseed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint paintseed
    {
      get { return _paintseed; }
      set { _paintseed = value; }
    }

    private uint _killeaterscoretype = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"killeaterscoretype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint killeaterscoretype
    {
      get { return _killeaterscoretype; }
      set { _killeaterscoretype = value; }
    }

    private uint _killeatervalue = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"killeatervalue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint killeatervalue
    {
      get { return _killeatervalue; }
      set { _killeatervalue = value; }
    }

    private string _customname = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"customname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string customname
    {
      get { return _customname; }
      set { _customname = value; }
    }
    private readonly global::System.Collections.Generic.List<CEconItemPreviewDataBlock.Sticker> _stickers = new global::System.Collections.Generic.List<CEconItemPreviewDataBlock.Sticker>();
    [global::ProtoBuf.ProtoMember(12, Name=@"stickers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CEconItemPreviewDataBlock.Sticker> stickers
    {
      get { return _stickers; }
    }
  

    private uint _inventory = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"inventory", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint inventory
    {
      get { return _inventory; }
      set { _inventory = value; }
    }

    private uint _origin = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint origin
    {
      get { return _origin; }
      set { _origin = value; }
    }

    private uint _questid = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }

    private uint _dropreason = default(uint);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"dropreason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dropreason
    {
      get { return _dropreason; }
      set { _dropreason = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Sticker")]
  public partial class Sticker : global::ProtoBuf.IExtensible
  {
    public Sticker() {}
    

    private uint _slot = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint slot
    {
      get { return _slot; }
      set { _slot = value; }
    }

    private uint _sticker_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sticker_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint sticker_id
    {
      get { return _sticker_id; }
      set { _sticker_id = value; }
    }

    private float _wear = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"wear", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float wear
    {
      get { return _wear; }
      set { _wear = value; }
    }

    private float _scale = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"scale", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float scale
    {
      get { return _scale; }
      set { _scale = value; }
    }

    private float _rotation = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rotation", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float rotation
    {
      get { return _rotation; }
      set { _rotation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchEndRewardDropsNotification")]
  public partial class CMsgGCCStrike15_v2_MatchEndRewardDropsNotification : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchEndRewardDropsNotification() {}
    

    private CEconItemPreviewDataBlock _iteminfo = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"iteminfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CEconItemPreviewDataBlock iteminfo
    {
      get { return _iteminfo; }
      set { _iteminfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgItemAcknowledged")]
  public partial class CMsgItemAcknowledged : global::ProtoBuf.IExtensible
  {
    public CMsgItemAcknowledged() {}
    

    private CEconItemPreviewDataBlock _iteminfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"iteminfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CEconItemPreviewDataBlock iteminfo
    {
      get { return _iteminfo; }
      set { _iteminfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest")]
  public partial class CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest() {}
    

    private ulong _param_s = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"param_s", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong param_s
    {
      get { return _param_s; }
      set { _param_s = value; }
    }

    private ulong _param_a = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"param_a", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong param_a
    {
      get { return _param_a; }
      set { _param_a = value; }
    }

    private ulong _param_d = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"param_d", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong param_d
    {
      get { return _param_d; }
      set { _param_d = value; }
    }

    private ulong _param_m = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"param_m", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong param_m
    {
      get { return _param_m; }
      set { _param_m = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse")]
  public partial class CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse() {}
    

    private CEconItemPreviewDataBlock _iteminfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"iteminfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CEconItemPreviewDataBlock iteminfo
    {
      get { return _iteminfo; }
      set { _iteminfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_TournamentMatchRewardDropsNotification")]
  public partial class CMsgGCCStrike15_v2_TournamentMatchRewardDropsNotification : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_TournamentMatchRewardDropsNotification() {}
    

    private ulong _match_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }

    private uint _defindex = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"defindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint defindex
    {
      get { return _defindex; }
      set { _defindex = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _accountids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"accountids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> accountids
    {
      get { return _accountids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames")]
  public partial class CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchListRequestLiveGameForUser")]
  public partial class CMsgGCCStrike15_v2_MatchListRequestLiveGameForUser : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchListRequestLiveGameForUser() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchListRequestRecentUserGames")]
  public partial class CMsgGCCStrike15_v2_MatchListRequestRecentUserGames : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchListRequestRecentUserGames() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchListRequestTournamentGames")]
  public partial class CMsgGCCStrike15_v2_MatchListRequestTournamentGames : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchListRequestTournamentGames() {}
    

    private int _eventid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eventid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eventid
    {
      get { return _eventid; }
      set { _eventid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchListRequestFullGameInfo")]
  public partial class CMsgGCCStrike15_v2_MatchListRequestFullGameInfo : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchListRequestFullGameInfo() {}
    

    private ulong _matchid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"matchid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong matchid
    {
      get { return _matchid; }
      set { _matchid = value; }
    }

    private ulong _outcomeid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"outcomeid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong outcomeid
    {
      get { return _outcomeid; }
      set { _outcomeid = value; }
    }

    private uint _token = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_MatchInfo")]
  public partial class CDataGCCStrike15_v2_MatchInfo : global::ProtoBuf.IExtensible//123
  {
    public CDataGCCStrike15_v2_MatchInfo() {}
    

    private ulong _matchid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"matchid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong matchid
    {
      get { return _matchid; }
      set { _matchid = value; }
    }

    private uint _matchtime = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"matchtime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint matchtime
    {
      get { return _matchtime; }
      set { _matchtime = value; }
    }

    private WatchableMatchInfo _watchablematchinfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"watchablematchinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public WatchableMatchInfo watchablematchinfo
    {
      get { return _watchablematchinfo; }
      set { _watchablematchinfo = value; }
    }

    private CMsgGCCStrike15_v2_MatchmakingServerRoundStats _roundstats_legacy = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"roundstats_legacy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgGCCStrike15_v2_MatchmakingServerRoundStats roundstats_legacy
    {
      get { return _roundstats_legacy; }
      set { _roundstats_legacy = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingServerRoundStats> _roundstatsall = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingServerRoundStats>();
    [global::ProtoBuf.ProtoMember(5, Name=@"roundstatsall", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_MatchmakingServerRoundStats> roundstatsall
    {
      get { return _roundstatsall; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_TournamentGroupTeam")]
  public partial class CDataGCCStrike15_v2_TournamentGroupTeam : global::ProtoBuf.IExtensible
  {
    public CDataGCCStrike15_v2_TournamentGroupTeam() {}
    

    private int _team_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id
    {
      get { return _team_id; }
      set { _team_id = value; }
    }

    private int _score = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int score
    {
      get { return _score; }
      set { _score = value; }
    }

    private bool _correctpick = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"correctpick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool correctpick
    {
      get { return _correctpick; }
      set { _correctpick = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_TournamentGroup")]
  public partial class CDataGCCStrike15_v2_TournamentGroup : global::ProtoBuf.IExtensible
  {
    public CDataGCCStrike15_v2_TournamentGroup() {}
    

    private uint _groupid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"groupid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint groupid
    {
      get { return _groupid; }
      set { _groupid = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _desc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }

    private uint _picks__deprecated = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"picks__deprecated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint picks__deprecated
    {
      get { return _picks__deprecated; }
      set { _picks__deprecated = value; }
    }
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroupTeam> _teams = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroupTeam>();
    [global::ProtoBuf.ProtoMember(5, Name=@"teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroupTeam> teams
    {
      get { return _teams; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _stage_ids = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"stage_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> stage_ids
    {
      get { return _stage_ids; }
    }
  

    private uint _picklockuntiltime = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"picklockuntiltime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint picklockuntiltime
    {
      get { return _picklockuntiltime; }
      set { _picklockuntiltime = value; }
    }

    private uint _pickableteams = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pickableteams", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pickableteams
    {
      get { return _pickableteams; }
      set { _pickableteams = value; }
    }

    private uint _points_per_pick = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"points_per_pick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint points_per_pick
    {
      get { return _points_per_pick; }
      set { _points_per_pick = value; }
    }
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup.Picks> _picks = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup.Picks>();
    [global::ProtoBuf.ProtoMember(10, Name=@"picks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup.Picks> picks
    {
      get { return _picks; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Picks")]
  public partial class Picks : global::ProtoBuf.IExtensible
  {
    public Picks() {}
    
    private readonly global::System.Collections.Generic.List<int> _pickids = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"pickids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> pickids
    {
      get { return _pickids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_TournamentSection")]
  public partial class CDataGCCStrike15_v2_TournamentSection : global::ProtoBuf.IExtensible
  {
    public CDataGCCStrike15_v2_TournamentSection() {}
    

    private uint _sectionid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sectionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint sectionid
    {
      get { return _sectionid; }
      set { _sectionid = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _desc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup> _groups = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup>();
    [global::ProtoBuf.ProtoMember(4, Name=@"groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentGroup> groups
    {
      get { return _groups; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDataGCCStrike15_v2_TournamentInfo")]
  public partial class CDataGCCStrike15_v2_TournamentInfo : global::ProtoBuf.IExtensible
  {
    public CDataGCCStrike15_v2_TournamentInfo() {}
    
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentSection> _sections = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentSection>();
    [global::ProtoBuf.ProtoMember(1, Name=@"sections", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_TournamentSection> sections
    {
      get { return _sections; }
    }
  

    private TournamentEvent _tournament_event = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tournament_event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TournamentEvent tournament_event
    {
      get { return _tournament_event; }
      set { _tournament_event = value; }
    }
    private readonly global::System.Collections.Generic.List<TournamentTeam> _tournament_teams = new global::System.Collections.Generic.List<TournamentTeam>();
    [global::ProtoBuf.ProtoMember(3, Name=@"tournament_teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentTeam> tournament_teams
    {
      get { return _tournament_teams; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_MatchList")]
  public partial class CMsgGCCStrike15_v2_MatchList : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_MatchList() {}
    

    private uint _msgrequestid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgrequestid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint msgrequestid
    {
      get { return _msgrequestid; }
      set { _msgrequestid = value; }
    }

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private uint _servertime = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"servertime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint servertime
    {
      get { return _servertime; }
      set { _servertime = value; }
    }
    private readonly global::System.Collections.Generic.List<CDataGCCStrike15_v2_MatchInfo> _matches = new global::System.Collections.Generic.List<CDataGCCStrike15_v2_MatchInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"matches", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDataGCCStrike15_v2_MatchInfo> matches
    {
      get { return _matches; }
    }
  
    private readonly global::System.Collections.Generic.List<TournamentTeam> _streams = new global::System.Collections.Generic.List<TournamentTeam>();
    [global::ProtoBuf.ProtoMember(5, Name=@"streams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TournamentTeam> streams
    {
      get { return _streams; }
    }
  

    private CDataGCCStrike15_v2_TournamentInfo _tournamentinfo = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tournamentinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDataGCCStrike15_v2_TournamentInfo tournamentinfo
    {
      get { return _tournamentinfo; }
      set { _tournamentinfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Predictions")]
  public partial class CMsgGCCStrike15_v2_Predictions : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Predictions() {}
    

    private uint _event_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint event_id
    {
      get { return _event_id; }
      set { _event_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Predictions.GroupMatchTeamPick> _group_match_team_picks = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Predictions.GroupMatchTeamPick>();
    [global::ProtoBuf.ProtoMember(2, Name=@"group_match_team_picks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Predictions.GroupMatchTeamPick> group_match_team_picks
    {
      get { return _group_match_team_picks; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GroupMatchTeamPick")]
  public partial class GroupMatchTeamPick : global::ProtoBuf.IExtensible
  {
    public GroupMatchTeamPick() {}
    

    private int _sectionid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sectionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sectionid
    {
      get { return _sectionid; }
      set { _sectionid = value; }
    }

    private int _groupid = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"groupid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int groupid
    {
      get { return _groupid; }
      set { _groupid = value; }
    }

    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }

    private int _teamid = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"teamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int teamid
    {
      get { return _teamid; }
      set { _teamid = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Fantasy")]
  public partial class CMsgGCCStrike15_v2_Fantasy : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Fantasy() {}
    

    private uint _event_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint event_id
    {
      get { return _event_id; }
      set { _event_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasyTeam> _teams = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasyTeam>();
    [global::ProtoBuf.ProtoMember(2, Name=@"teams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasyTeam> teams
    {
      get { return _teams; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FantasySlot")]
  public partial class FantasySlot : global::ProtoBuf.IExtensible
  {
    public FantasySlot() {}
    

    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private int _pick = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pick
    {
      get { return _pick; }
      set { _pick = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FantasyTeam")]
  public partial class FantasyTeam : global::ProtoBuf.IExtensible
  {
    public FantasyTeam() {}
    

    private int _sectionid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sectionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sectionid
    {
      get { return _sectionid; }
      set { _sectionid = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasySlot> _slots = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasySlot>();
    [global::ProtoBuf.ProtoMember(2, Name=@"slots", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_Fantasy.FantasySlot> slots
    {
      get { return _slots; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CAttribute_String")]
  public partial class CAttribute_String : global::ProtoBuf.IExtensible
  {
    public CAttribute_String() {}
    

    private string _value = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCToGCReloadVersions")]
  public partial class CMsgGCToGCReloadVersions : global::ProtoBuf.IExtensible
  {
    public CMsgGCToGCReloadVersions() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgCStrike15Welcome")]
  public partial class CMsgCStrike15Welcome : global::ProtoBuf.IExtensible
  {
    public CMsgCStrike15Welcome() {}
    

    private uint _store_item_hash = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"store_item_hash", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint store_item_hash
    {
      get { return _store_item_hash; }
      set { _store_item_hash = value; }
    }

    private uint _timeplayedconsecutively = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"timeplayedconsecutively", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeplayedconsecutively
    {
      get { return _timeplayedconsecutively; }
      set { _timeplayedconsecutively = value; }
    }

    private uint _time_first_played = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"time_first_played", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time_first_played
    {
      get { return _time_first_played; }
      set { _time_first_played = value; }
    }

    private uint _last_time_played = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"last_time_played", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_time_played
    {
      get { return _last_time_played; }
      set { _last_time_played = value; }
    }

    private uint _last_ip_address = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"last_ip_address", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_ip_address
    {
      get { return _last_ip_address; }
      set { _last_ip_address = value; }
    }

    private ulong _gscookieid = default(ulong);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"gscookieid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong gscookieid
    {
      get { return _gscookieid; }
      set { _gscookieid = value; }
    }

    private ulong _uniqueid = default(ulong);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"uniqueid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong uniqueid
    {
      get { return _uniqueid; }
      set { _uniqueid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientVarValueNotificationInfo")]
  public partial class CMsgGCCStrike15_v2_ClientVarValueNotificationInfo : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientVarValueNotificationInfo() {}
    

    private string _value_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value_name
    {
      get { return _value_name; }
      set { _value_name = value; }
    }

    private int _value_int = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value_int", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value_int
    {
      get { return _value_int; }
      set { _value_int = value; }
    }

    private uint _server_addr = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"server_addr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_addr
    {
      get { return _server_addr; }
      set { _server_addr = value; }
    }

    private uint _server_port = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"server_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_port
    {
      get { return _server_port; }
      set { _server_port = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _choked_blocks = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"choked_blocks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> choked_blocks
    {
      get { return _choked_blocks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ServerVarValueNotificationInfo")]
  public partial class CMsgGCCStrike15_v2_ServerVarValueNotificationInfo : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ServerVarValueNotificationInfo() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _viewangles = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"viewangles", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> viewangles
    {
      get { return _viewangles; }
    }
  

    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_GiftsLeaderboardRequest")]
  public partial class CMsgGCCStrike15_v2_GiftsLeaderboardRequest : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_GiftsLeaderboardRequest() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_GiftsLeaderboardResponse")]
  public partial class CMsgGCCStrike15_v2_GiftsLeaderboardResponse : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_GiftsLeaderboardResponse() {}
    

    private uint _servertime = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"servertime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint servertime
    {
      get { return _servertime; }
      set { _servertime = value; }
    }

    private uint _time_period_seconds = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time_period_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time_period_seconds
    {
      get { return _time_period_seconds; }
      set { _time_period_seconds = value; }
    }

    private uint _total_gifts_given = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"total_gifts_given", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint total_gifts_given
    {
      get { return _total_gifts_given; }
      set { _total_gifts_given = value; }
    }

    private uint _total_givers = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"total_givers", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint total_givers
    {
      get { return _total_givers; }
      set { _total_givers = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgGCCStrike15_v2_GiftsLeaderboardResponse.GiftLeaderboardEntry> _entries = new global::System.Collections.Generic.List<CMsgGCCStrike15_v2_GiftsLeaderboardResponse.GiftLeaderboardEntry>();
    [global::ProtoBuf.ProtoMember(5, Name=@"entries", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgGCCStrike15_v2_GiftsLeaderboardResponse.GiftLeaderboardEntry> entries
    {
      get { return _entries; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GiftLeaderboardEntry")]
  public partial class GiftLeaderboardEntry : global::ProtoBuf.IExtensible
  {
    public GiftLeaderboardEntry() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private uint _gifts = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gifts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gifts
    {
      get { return _gifts; }
      set { _gifts = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_ClientSubmitSurveyVote")]
  public partial class CMsgGCCStrike15_v2_ClientSubmitSurveyVote : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_ClientSubmitSurveyVote() {}
    

    private uint _survey_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"survey_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint survey_id
    {
      get { return _survey_id; }
      set { _survey_id = value; }
    }

    private uint _vote = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"vote", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint vote
    {
      get { return _vote; }
      set { _vote = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Server2GCClientValidate")]
  public partial class CMsgGCCStrike15_v2_Server2GCClientValidate : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Server2GCClientValidate() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Server2GCPureServerValidationFailure")]
  public partial class CMsgGCCStrike15_v2_Server2GCPureServerValidationFailure : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Server2GCPureServerValidationFailure() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private string _path = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string path
    {
      get { return _path; }
      set { _path = value; }
    }

    private string _file = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"file", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file
    {
      get { return _file; }
      set { _file = value; }
    }

    private uint _crc = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"crc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint crc
    {
      get { return _crc; }
      set { _crc = value; }
    }

    private int _hash = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"hash", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hash
    {
      get { return _hash; }
      set { _hash = value; }
    }

    private int _len = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"len", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int len
    {
      get { return _len; }
      set { _len = value; }
    }

    private int _pack_number = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"pack_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pack_number
    {
      get { return _pack_number; }
      set { _pack_number = value; }
    }

    private int _pack_file_id = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pack_file_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pack_file_id
    {
      get { return _pack_file_id; }
      set { _pack_file_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_GC2ClientTournamentInfo")]
  public partial class CMsgGCCStrike15_v2_GC2ClientTournamentInfo : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_GC2ClientTournamentInfo() {}
    

    private uint _eventid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eventid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint eventid
    {
      get { return _eventid; }
      set { _eventid = value; }
    }

    private uint _stageid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }

    private uint _game_type = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"game_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint game_type
    {
      get { return _game_type; }
      set { _game_type = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _teamids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"teamids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> teamids
    {
      get { return _teamids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSOEconCoupon")]
  public partial class CSOEconCoupon : global::ProtoBuf.IExtensible
  {
    public CSOEconCoupon() {}
    

    private uint _entryid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"entryid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint entryid
    {
      get { return _entryid; }
      set { _entryid = value; }
    }

    private uint _defidx = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"defidx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint defidx
    {
      get { return _defidx; }
      set { _defidx = value; }
    }

    private uint _expiration_date = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"expiration_date", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint expiration_date
    {
      get { return _expiration_date; }
      set { _expiration_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSOQuestProgress")]
  public partial class CSOQuestProgress : global::ProtoBuf.IExtensible
  {
    public CSOQuestProgress() {}
    

    private uint _questid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }

    private uint _points_remaining = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"points_remaining", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint points_remaining
    {
      get { return _points_remaining; }
      set { _points_remaining = value; }
    }

    private uint _bonus_points = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bonus_points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint bonus_points
    {
      get { return _bonus_points; }
      set { _bonus_points = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSOPersonaDataPublic")]
  public partial class CSOPersonaDataPublic : global::ProtoBuf.IExtensible
  {
    public CSOPersonaDataPublic() {}
    

    private int _player_level = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_level
    {
      get { return _player_level; }
      set { _player_level = value; }
    }

    private PlayerCommendationInfo _commendation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"commendation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerCommendationInfo commendation
    {
      get { return _commendation; }
      set { _commendation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGC_GlobalGame_Subscribe")]
  public partial class CMsgGC_GlobalGame_Subscribe : global::ProtoBuf.IExtensible
  {
    public CMsgGC_GlobalGame_Subscribe() {}
    

    private ulong _ticket = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGC_GlobalGame_Unsubscribe")]
  public partial class CMsgGC_GlobalGame_Unsubscribe : global::ProtoBuf.IExtensible
  {
    public CMsgGC_GlobalGame_Unsubscribe() {}
    

    private int _timeleft = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"timeleft", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int timeleft
    {
      get { return _timeleft; }
      set { _timeleft = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGC_GlobalGame_Play")]
  public partial class CMsgGC_GlobalGame_Play : global::ProtoBuf.IExtensible
  {
    public CMsgGC_GlobalGame_Play() {}
    

    private ulong _ticket = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }

    private uint _gametimems = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gametimems", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gametimems
    {
      get { return _gametimems; }
      set { _gametimems = value; }
    }

    private uint _msperpoint = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"msperpoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint msperpoint
    {
      get { return _msperpoint; }
      set { _msperpoint = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_AcknowledgePenalty")]
  public partial class CMsgGCCStrike15_v2_AcknowledgePenalty : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_AcknowledgePenalty() {}
    

    private int _acknowledged = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"acknowledged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int acknowledged
    {
      get { return _acknowledged; }
      set { _acknowledged = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin")]
  public partial class CMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCCStrike15_v2_Client2GCStreamUnlock")]
  public partial class CMsgGCCStrike15_v2_Client2GCStreamUnlock : global::ProtoBuf.IExtensible
  {
    public CMsgGCCStrike15_v2_Client2GCStreamUnlock() {}
    

    private ulong _ticket = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }

    private int _os = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"os", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int os
    {
      get { return _os; }
      set { _os = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ECsgoGCMsg", EnumPassthru=true)]
    public enum ECsgoGCMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Base", Value=9100)]
      k_EMsgGCCStrike15_v2_Base = 9100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingStart", Value=9101)]
      k_EMsgGCCStrike15_v2_MatchmakingStart = 9101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingStop", Value=9102)]
      k_EMsgGCCStrike15_v2_MatchmakingStop = 9102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing", Value=9103)]
      k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing = 9103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate", Value=9104)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate = 9104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ServerReserve", Value=9105)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ServerReserve = 9105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse", Value=9106)]
      k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse = 9106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve", Value=9107)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve = 9107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingServerRoundStats", Value=9108)]
      k_EMsgGCCStrike15_v2_MatchmakingServerRoundStats = 9108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello", Value=9109)]
      k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello = 9109,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello", Value=9110)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello = 9110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingServerMatchEnd", Value=9111)]
      k_EMsgGCCStrike15_v2_MatchmakingServerMatchEnd = 9111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon", Value=9112)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon = 9112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingServer2GCKick", Value=9113)]
      k_EMsgGCCStrike15_v2_MatchmakingServer2GCKick = 9113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm", Value=9114)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ServerConfirm = 9114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGCOperationalStats", Value=9115)]
      k_EMsgGCCStrike15_v2_MatchmakingGCOperationalStats = 9115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingGC2ServerRankUpdate", Value=9116)]
      k_EMsgGCCStrike15_v2_MatchmakingGC2ServerRankUpdate = 9116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate", Value=9117)]
      k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate = 9117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty", Value=9118)]
      k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty = 9118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientReportPlayer", Value=9119)]
      k_EMsgGCCStrike15_v2_ClientReportPlayer = 9119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientReportServer", Value=9120)]
      k_EMsgGCCStrike15_v2_ClientReportServer = 9120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientCommendPlayer", Value=9121)]
      k_EMsgGCCStrike15_v2_ClientCommendPlayer = 9121,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientReportResponse", Value=9122)]
      k_EMsgGCCStrike15_v2_ClientReportResponse = 9122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery", Value=9123)]
      k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery = 9123,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse", Value=9124)]
      k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse = 9124,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_WatchInfoUsers", Value=9126)]
      k_EMsgGCCStrike15_v2_WatchInfoUsers = 9126,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile", Value=9127)]
      k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile = 9127,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_PlayersProfile", Value=9128)]
      k_EMsgGCCStrike15_v2_PlayersProfile = 9128,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_SetMyMedalsInfo", Value=9129)]
      k_EMsgGCCStrike15_v2_SetMyMedalsInfo = 9129,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate", Value=9131)]
      k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate = 9131,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment", Value=9132)]
      k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment = 9132,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus", Value=9133)]
      k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus = 9133,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GC2ClientTextMsg", Value=9134)]
      k_EMsgGCCStrike15_v2_GC2ClientTextMsg = 9134,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Client2GCTextMsg", Value=9135)]
      k_EMsgGCCStrike15_v2_Client2GCTextMsg = 9135,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops", Value=9136)]
      k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops = 9136,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification", Value=9137)]
      k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification = 9137,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2", Value=9138)]
      k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2 = 9138,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchList", Value=9139)]
      k_EMsgGCCStrike15_v2_MatchList = 9139,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames", Value=9140)]
      k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames = 9140,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames", Value=9141)]
      k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames = 9141,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate", Value=9142)]
      k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate = 9142,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo", Value=9144)]
      k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo = 9144,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_TournamentMatchRewardDropsNotification", Value=9145)]
      k_EMsgGCCStrike15_v2_TournamentMatchRewardDropsNotification = 9145,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames", Value=9146)]
      k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames = 9146,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo", Value=9147)]
      k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo = 9147,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest", Value=9148)]
      k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest = 9148,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse", Value=9149)]
      k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse = 9149,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo", Value=9150)]
      k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo = 9150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCToGCReloadVersions", Value=9151)]
      k_EMsgGCToGCReloadVersions = 9151,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote", Value=9152)]
      k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote = 9152,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Server2GCClientValidate", Value=9153)]
      k_EMsgGCCStrike15_v2_Server2GCClientValidate = 9153,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser", Value=9154)]
      k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser = 9154,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Server2GCPureServerValidationFailure", Value=9155)]
      k_EMsgGCCStrike15_v2_Server2GCPureServerValidationFailure = 9155,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest", Value=9156)]
      k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest = 9156,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse", Value=9157)]
      k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse = 9157,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_AccountPrivacySettings", Value=9158)]
      k_EMsgGCCStrike15_v2_AccountPrivacySettings = 9158,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_SetMyActivityInfo", Value=9159)]
      k_EMsgGCCStrike15_v2_SetMyActivityInfo = 9159,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions", Value=9160)]
      k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions = 9160,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions", Value=9161)]
      k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions = 9161,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_DraftSummary", Value=9162)]
      k_EMsgGCCStrike15_v2_DraftSummary = 9162,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData", Value=9163)]
      k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData = 9163,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientRequestJoinServerData", Value=9164)]
      k_EMsgGCCStrike15_v2_ClientRequestJoinServerData = 9164,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_ClientRequestNewMission", Value=9165)]
      k_EMsgGCCStrike15_v2_ClientRequestNewMission = 9165,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GC2ServerNotifyXPRewarded", Value=9166)]
      k_EMsgGCCStrike15_v2_GC2ServerNotifyXPRewarded = 9166,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo", Value=9167)]
      k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo = 9167,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGC_GlobalGame_Subscribe", Value=9168)]
      k_EMsgGC_GlobalGame_Subscribe = 9168,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGC_GlobalGame_Unsubscribe", Value=9169)]
      k_EMsgGC_GlobalGame_Unsubscribe = 9169,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGC_GlobalGame_Play", Value=9170)]
      k_EMsgGC_GlobalGame_Play = 9170,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_AcknowledgePenalty", Value=9171)]
      k_EMsgGCCStrike15_v2_AcknowledgePenalty = 9171,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin", Value=9172)]
      k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin = 9172,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_GC2ClientGlobalStats", Value=9173)]
      k_EMsgGCCStrike15_v2_GC2ClientGlobalStats = 9173,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_Client2GCStreamUnlock", Value=9174)]
      k_EMsgGCCStrike15_v2_Client2GCStreamUnlock = 9174,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_FantasyRequestClientData", Value=9175)]
      k_EMsgGCCStrike15_v2_FantasyRequestClientData = 9175,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCCStrike15_v2_FantasyUpdateClientData", Value=9176)]
      k_EMsgGCCStrike15_v2_FantasyUpdateClientData = 9176
    }
  
}
#pragma warning restore 1591
