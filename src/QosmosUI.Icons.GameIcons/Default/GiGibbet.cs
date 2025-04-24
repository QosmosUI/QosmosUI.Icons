// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGibbet : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M82.063 22.97v55.468h10.624v-.157h85.907v.157h67.22L356.5 189.03v303.876h88.313V22.97H82.063zm225.125 55.468H356.5v49.28l-49.313-49.28zm-188.47 18.53v119.313c-6.382 11.06-15.59 27.544-23.374 45.032-7.905 17.757-14.563 36.232-14.563 52.782 0 15.672 4.607 30.03 12.657 40.906 8.05 10.876 20.057 18.438 33.688 18.438 13.63 0 25.637-7.562 33.688-18.438 8.05-10.876 12.687-25.234 12.687-40.906 0-16.68-6.99-35.573-15.03-53.563-7.144-15.975-15.21-30.695-21.032-40.905V96.97h-18.72zm8.126 143.188h.562c4.58 8.437 9.43 17.778 14 28 7.59 16.977 13.406 35.015 13.406 45.938 0 11.93-3.682 22.556-9.03 29.78-5.35 7.226-11.856 10.876-18.657 10.876-6.8 0-13.308-3.65-18.656-10.875-5.35-7.225-9-17.85-9-29.78 0-11.054 5.498-28.48 12.936-45.19 4.603-10.34 9.635-19.947 14.438-28.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
