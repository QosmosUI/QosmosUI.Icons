// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaRocketchat : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 32 32";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M 7.5488281 5 C 6.2638281 5 5.055 5.3086094 4 5.8496094 C 5.422467 6.9694938 6.4322525 8.5274703 6.8359375 10.300781 C 5.0652471 11.854193 4 13.838545 4 16 C 4 18.1 5.0028438 20.110797 6.8398438 21.716797 C 6.5498438 22.966797 5.9480312 24.134047 5.0820312 25.123047 L 4.0136719 26.345703 L 5.5859375 26.751953 C 6.2259375 26.917953 6.8868281 27 7.5488281 27 C 9.7768281 27 11.841828 26.197516 13.423828 24.728516 C 14.425828 24.908516 15.458 25 16.5 25 C 23.393 25 29 20.962 29 16 C 29 11.038 23.393 7 16.5 7 C 15.440923 7 14.418235 7.1058017 13.435547 7.2851562 C 11.913547 5.8774278 9.8442485 5 7.5488281 5 z M 16.5 9 C 22.29 9 27 12.14 27 16 C 27 19.86 22.29 23 16.5 23 C 15.412 23 14.338594 22.888969 13.308594 22.667969 L 12.757812 22.548828 L 12.371094 22.957031 C 11.147094 24.252031 9.469625 24.976 7.640625 25 C 8.290625 23.917 8.727875 22.724516 8.921875 21.478516 L 9.0136719 20.896484 L 8.5488281 20.535156 C 6.9058281 19.256156 6 17.646 6 16 C 6 12.14 10.71 9 16.5 9 z M 11.5 15 A 1.5 1.5 0 0 0 11.5 18 A 1.5 1.5 0 0 0 11.5 15 z M 16.5 15 A 1.5 1.5 0 0 0 16.5 18 A 1.5 1.5 0 0 0 16.5 15 z M 21.5 15 A 1.5 1.5 0 0 0 21.5 18 A 1.5 1.5 0 0 0 21.5 15 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
