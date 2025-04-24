// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMusicNote1 : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Music_Note_1");
		builder.AddAttribute(15, "data-name", "Music Note 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.05,3.657a2.487,2.487,0,0,0-2.03-.56l-7.88,1.33a2.483,2.483,0,0,0-2.08,2.46v8.82a3,3,0,1,0,1,2.23V9.387l10.88-1.83v6.22a2.936,2.936,0,0,0-2-.77,3,3,0,1,0,3,3V5.567A2.513,2.513,0,0,0,20.05,3.657ZM6.06,19.937a2,2,0,1,1,2-2A1.993,1.993,0,0,1,6.06,19.937Zm11.88-1.93a2,2,0,1,1,2-2A2,2,0,0,1,17.94,18.007Zm2-11.46L9.06,8.377V6.887a1.483,1.483,0,0,1,1.25-1.47l7.88-1.33a1.493,1.493,0,0,1,1.75,1.48Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
