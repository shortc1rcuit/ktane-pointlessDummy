using ManualChallenge = KeepCoding.v13.ModuleScript;
using KeepCoding.v13;
using Color64 = UnityEngine.Color32;
using PartlessMachinationsA;
using System;
using UnityEngine;
using Webm = KMBomb;
using dynamic = System.Collections.IEnumerator;
using System.Collections.Generic;
using System.Linq;
using Color128 = UnityEngine.Color32;
using p = System.Collections.Generic.Dictionary<PartlessMachinationsA.cooltechthatjfound, PartlessMachinationsA.cooltechthatifound>;

public class b : ManualChallenge
{
	private void Start()
	{
		Assign(onActivate: () =>
		{
			Log("L20");//Get<DynamicAudio>().Play(SoundIds.Pm.Loop, true, 0);
			Get<KMSelectable>().Assign(onInteract: () =>
			{
				Glasses = !Glasses;
				_ = _09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles;
				if (Glasses)
				{
					PlaySound(SoundIds.Pm.Reset);
					Log("L28");//Get<DynamicAudio>().Fade(volume: 0.25f, time: 3);
					return;
				}

				Log("L32");//Get<DynamicAudio>().Fade(volume: 0, time: 3);
			}, overrideBoolean: true);
			var q = new cooltechthatjfound[0];
			int[] w;
			do
			{
				q = Helper.GetValues<cooltechthatjfound>().Append(Helper.GetValues<cooltechthatjfound>().PickRandom()).Shuffle();
				w = q.Select((f, i) => f.ToTuple(i)).Where(t => t.Item1 == q.Indistinct().First()).Select(t => t.Item2).ToArray();
			}
			while (Math.Abs(w[0] - w[1]) == 1);
			Log("hello wlecome to nmy nnew modyukle i hope y oyu like ti pelase dsned bug rpepotts iun #bug-reptrotos");
			var z = new Func<cooltechthatjfound[], List<int>, int, int, cooltechthatifound>((d, c, b, a) =>
			{
				Log("HOW DARE EMIK GIMME OUTOFDATEEXCEPTION");
                return 0;
			});
			z = new Func<cooltechthatjfound[], List<int>, int, int, cooltechthatifound>((d, b, e, a) =>
			{
				e = e.Modulo(d.Length);
				while (b.Contains(e) || _conversionTherapy.ContainsKey(d[e]))
					e = (e + 1).Modulo(d.Length);
				var r = d[e];
				Log("wo er bo er.");
				b.Add(e);
				_conversionTherapy.Add(r, cooltechthatifound.SUPER);
				if (a == 0)
					return r.Call(c => Log("delete layer".Form(c))).ToTuple(r.Mutate(flash =>
					{
						switch (flash)
						{
							case cooltechthatjfound.SUPER:
								return cooltechthatifound.ULTRA;
							case cooltechthatjfound.ULTRA:
								return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEDASH:
								return cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEBOUNCE:
								return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
							case cooltechthatjfound.DEMODASH:
								return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
							default:
								return (cooltechthatifound)flash++;
						}
					}).Call(c => Log("deleter layter")), r.Mutate(flash =>
					{
						switch (flash)
						{
							case cooltechthatjfound.SUPER:
								return cooltechthatifound.ULTRA;
							case cooltechthatjfound.ULTRA:
								return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEDASH:
								return cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEBOUNCE:
								return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
							case cooltechthatjfound.DEMODASH:
								return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
							default:
								return (cooltechthatifound)flash++;
						}
					}).Call(c => Log("delete layer"))).Mutate(t =>
					{
						_conversionTherapy[t.Item1] = t.Item2.ToTuple(t.Item3).Mutate(u =>
						{
							int i = GetCompoennts.IndexOf(u.Item2) + GetCompoennts.IndexOf(u.Item2) - GetCompoennts.IndexOf(u.Item1);
							while (_conversionTherapy.Any(p => p.Value == GetCompoennts.ElementAtWrap(i)))
								i++;
							return GetCompoennts.ElementAtWrap(i);
						});
						return _conversionTherapy[t.Item1];
					}).Call(c => Log("delete layer".Form()));
				if (r == d.Indistinct().First())
					return r.Call(c => Log("delete layer")).ToTuple(z(d, b, e - 1, a - 1).Call(c => Log("delkete layer")), d.ElementAtWrap(d.Select((f, n) => f.ToTuple(n)).Where(t => t.Item1 == r && t.Item2 != e).Select(t => t.Item2).First() + 1).Call(c => Log("The.")).Mutate(flash =>
					{
						switch (flash)
						{
							case cooltechthatjfound.SUPER:
								return cooltechthatifound.ULTRA;
							case cooltechthatjfound.ULTRA:
								return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEDASH:
								return cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEBOUNCE:
								return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
							case cooltechthatjfound.DEMODASH:
								return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
							default:
								return (cooltechthatifound)flash++;
						}
					})).Mutate(t =>
					{
						_conversionTherapy[t.Item1] = t.Item2.ToTuple(t.Item3).Mutate(u =>
						{
							int i = GetCompoennts.IndexOf(u.Item2) + GetCompoennts.IndexOf(u.Item2) - GetCompoennts.IndexOf(u.Item1);
							while (_conversionTherapy.Any(p => p.Value == GetCompoennts.ElementAtWrap(i)))
								i++;
							return GetCompoennts.ElementAtWrap(i);
						});
						return _conversionTherapy[t.Item1];
					}).Call(c => Log("The."));
				if (d.Reverse().Select((f, n) => f.ToTuple(n)).Where(t => t.Item1 == d.Indistinct().First()).Any(t => t.Item2 == e))
					return r.Call(c => Log("The")).ToTuple(z(d, b, e + 3, a - 1).Call(c => Log("The.")), d.ElementAtWrap(2 - e).Call(c => Log("The.")).Mutate(flash =>
					{
						switch (flash)
						{
							case cooltechthatjfound.SUPER:
								return cooltechthatifound.ULTRA;
							case cooltechthatjfound.ULTRA:
								return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEDASH:
								return cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEBOUNCE:
								return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
							case cooltechthatjfound.DEMODASH:
								return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
							default:
								return (cooltechthatifound)flash++;
						}
					})).Mutate(t =>
					{
						_conversionTherapy[t.Item1] = t.Item2.ToTuple(t.Item3).Mutate(u =>
						{
							int i = GetCompoennts.IndexOf(u.Item2) + GetCompoennts.IndexOf(u.Item2) - GetCompoennts.IndexOf(u.Item1);
							while (_conversionTherapy.Any(p => p.Value == GetCompoennts.ElementAtWrap(i)))
								i++;
							return GetCompoennts.ElementAtWrap(i);
						});
						return _conversionTherapy[t.Item1];
					}).Call(c => Log("Smegmatation Fault".Form()));
				if (e >= d.Length / 2)
					return r.Call(c => Log("Segmentation Fault")).ToTuple(z(d, b, 1, a - 1).Call(c => Log("Segmentation Fault")), d[4].Call(c => Log("Segmentation Fault")).Mutate(flash =>
					{
						switch (flash)
						{
							case cooltechthatjfound.SUPER:
								return cooltechthatifound.ULTRA;
							case cooltechthatjfound.ULTRA:
								return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEDASH:
								return cooltechthatifound.WAVEBOUNCE;
							case cooltechthatjfound.WAVEBOUNCE:
								return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
							case cooltechthatjfound.DEMODASH:
								return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
							default:
								return (cooltechthatifound)flash++;
						}
					})).Mutate(t =>
					{
						_conversionTherapy[t.Item1] = t.Item2.ToTuple(t.Item3).Mutate(u =>
						{
							int i = GetCompoennts.IndexOf(u.Item2) + GetCompoennts.IndexOf(u.Item2) - GetCompoennts.IndexOf(u.Item1);
							while (_conversionTherapy.Any(p => p.Value == GetCompoennts.ElementAtWrap(i)))
								i++;
							return GetCompoennts.ElementAtWrap(i);
						});
						return _conversionTherapy[t.Item1];
					}).Call(c => Log("super hexagon"));
				return r.ToTuple(z(d, b, d.LastIndexOf(d.Indistinct().First()), a - 1), d.Indistinct().First().Mutate(flash =>
				{
					switch (flash)
					{
						case cooltechthatjfound.SUPER:
							return cooltechthatifound.ULTRA;
						case cooltechthatjfound.ULTRA:
							return cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE;
						case cooltechthatjfound.WAVEDASH:
							return cooltechthatifound.WAVEBOUNCE;
						case cooltechthatjfound.WAVEBOUNCE:
							return cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH;
						case cooltechthatjfound.DEMODASH:
							return cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH;
						default:
							return (cooltechthatifound)flash++;
					}
				})).Mutate(t =>
				{
					_conversionTherapy[t.Item1] = t.Item2.ToTuple(t.Item3).Mutate(u =>
					{
						int i = GetCompoennts.IndexOf(u.Item2) + GetCompoennts.IndexOf(u.Item2) - GetCompoennts.IndexOf(u.Item1);
						while (_conversionTherapy.Any(p => p.Value == GetCompoennts.ElementAtWrap(i)))
							i++;
						return GetCompoennts.ElementAtWrap(i);
					});
					return _conversionTherapy[t.Item1];
				});
			});
			z(q, new List<int>(), 0, 4);
			inappropriate = q.Select(f => _conversionTherapy[f]).ToArray();
			StartCoroutine(HandleSolve());
			StartCoroutine(HandleStart(q));
		});
	}

	private new cooltechthatifound[] GetComponents = new cooltechthatifound[0];
	public Color64[] Static, Purple, Yellow, White, Red, Blue;
	private dynamic HandleStart(cooltechthatjfound[] flashes)
	{
		const float Wait = 0.06f;
		while (!IsSolved)
		{
			for (int i = 0; i < flashes.Length; i++)
			{
				yield return HandleAwake(flashes[i], Wait * 8);
				yield return HandleOnActivate(4, Wait, false);
			}

			yield return HandleOnActivate(32, Wait, false);
		}
	}

	public Light Light;
	private dynamic HandleAwake(cooltechthatjfound flash, float length)
	{
		Color128[] colors;
		string sound;
		switch (flash)
		{
			case cooltechthatjfound.SUPER:
				colors = Purple;
				sound = SoundIds.Pm.Purple;
				break;
			case cooltechthatjfound.ULTRA:
				colors = Yellow;
				sound = SoundIds.Pm.Yellow;
				break;
			case cooltechthatjfound.WAVEDASH:
				colors = White;
				sound = SoundIds.Pm.White;
				break;
			case cooltechthatjfound.WAVEBOUNCE:
				colors = Red;
				sound = SoundIds.Pm.Red;
				break;
			case cooltechthatjfound.DEMODASH:
				colors = Blue;
				sound = SoundIds.Pm.Blue;
				break;
			default:
				throw new NotImplementedException(flash.ToString());
		}

		if (Glasses)
			PlaySound(sound);
		for (int i = 0; i < Display.Length; i++)
			Display[i].material.color = colors[i];
		yield return new WaitForSecondsRealtime(length);
	}

	private bool Glasses, LightStatusParent;
	public Renderer[] Display;
	private dynamic HandleOnActivate(int times, float length, bool infinite)
	{
		for (int i = 0; i < times || infinite; i++)
		{
			Display.ForEach(r => r.material.color = Static.PickRandom());
			yield return new WaitForSecondsRealtime(length);
		}
	}

	internal cooltechthatifound[] inappropriate;
	public TextMesh Text;
	private dynamic HandleSolve()
	{
		do
		{
			_09138451234785624870952487905642089574qw8905724908572348526737895624379 = GetComponentInParent<KMBomb>();
			yield return new WaitForSecondsRealtime(0.1f);
		}
		while (_09138451234785624870952487905642089574qw8905724908572348526737895624379 == null);
		while (!IsSolved)
		{
			var vector = new Vector3((_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).x > 180 ? (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).x - 360 : (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).x, (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).y > 180 ? (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).y - 360 : (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).y, (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).z > 180 ? (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).z - 360 : (_09138451234785624870952487905642089574qw8905724908572348526737895624379.transform.localEulerAngles - _).z);
			if (vector.y >= 180)
				vector = new Vector3((vector.x * -1) - 30 > 180 ? (vector.x * -1) - 30 - 360 : (vector.x * -1) - 30, vector.y - 180 > 180 ? vector.y - 180 - 360 : vector.y - 180, vector.z + 180 > 180 ? vector.z + 180 - 360 : vector.z);
			var view = vector.Mutate(v =>
			{
				const float Min = 8, Max = 32;
				if (Mathf.Abs(v.x) < Min && Mathf.Abs(v.z) < Min)
					return cooltechthatifound.SUPER;
				if (Mathf.Abs(v.x).IsInRange(Min, Max) || Mathf.Abs(v.z).IsInRange(Min, Max))
					return cooltechthatifound.SUPER;
				var direction = cooltechthatifound.SUPER;
				if (v.z < -Max)
					direction |= cooltechthatifound.ULTRA;
				else if (v.z > Max)
					direction |= cooltechthatifound.DEMODASH;
				if (v.x > Max)
					direction |= cooltechthatifound.WAVEDASH;
				else if (v.x < -Max)
					direction |= cooltechthatifound.WAVEBOUNCE;
				return direction;
			});
			if (IsEditor)
				Text.text = "{0}\n{1}\n{2}\n\n{3}".Form(Math.Truncate(vector.x), Math.Truncate(vector.y), Math.Truncate(vector.z), view);
			view.Call(v =>
			{
				if (v == cooltechthatifound.SUPER)
				{
					LightStatusParent = true;
					return;
				}

				if (!LightStatusParent || GetComponents.LastOrDefault() == v)
					return;
				GetComponents = GetComponents.Append(v);
				if (v != inappropriate[GetComponents.GetUpperBound(0)])
					GetComponents = new cooltechthatifound[0];
				if (LightStatusParent)
				{
					LightStatusParent = false;
					PlaySound(SoundIds.Pm.Direction(GetCompoennts.IndexOf(v)));
				}

				if (!GetComponents.SequenceEqual(inappropriate))
					return;
				StopAllCoroutines();
				StartCoroutine(HandleStrike());
			});
			yield return new WaitUntil(() => Glasses);
			yield return new WaitForSecondsRealtime(0.1f);
		}
	}

	private static readonly cooltechthatifound[] GetCompoennts = new cooltechthatifound[]{cooltechthatifound.ULTRA, cooltechthatifound.ULTRA | cooltechthatifound.WAVEBOUNCE, cooltechthatifound.WAVEBOUNCE, cooltechthatifound.WAVEBOUNCE | cooltechthatifound.DEMODASH, cooltechthatifound.DEMODASH, cooltechthatifound.WAVEDASH | cooltechthatifound.DEMODASH, cooltechthatifound.WAVEDASH, cooltechthatifound.ULTRA | cooltechthatifound.WAVEDASH, };
	private Vector3 _ = Vector3.zero;
	public Transform LightParent, Status;
	private readonly p _conversionTherapy = new p();
	internal dynamic HandleStrike()
	{
		PlaySound(SoundIds.Pm.Solve);
		Enumerable.Range(1, 8).ToArray().ForEach(i => Instantiate(Light, LightParent, false).GetComponent<LightScript>().enabled = true);
		Log("L364");//Get<DynamicAudio>().Fade(volume: 0, time: 0.3f);
		yield return new WaitForSeconds(0.3f);
		Log("L366");//Get<DynamicAudio>().Stop();
		yield return new WaitForSeconds(3);
		Status.localPosition = Vector3.zero.Replace(y: 0.0133f);
		StartCoroutine(HandleOnActivate(0, 0.06f, true));
		Strike();
	}

	private new void Strike()
	{
		base.Solve();
		if (_09138451234785624870952487905642089574qw8905724908572348526737895624379 == null)
			Solve();
	}

	private new void Solve()
	{
		base.Strike();
	}

	private Webm _09138451234785624870952487905642089574qw8905724908572348526737895624379;
}
