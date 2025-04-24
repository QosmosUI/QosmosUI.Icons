// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiVolumeMute : ComponentBase
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
		builder.AddAttribute(14, "id", "Volume_Mute");
		builder.AddAttribute(15, "data-name", "Volume Mute");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M13.817,19.936a1.424,1.424,0,0,1-.719-.2L9.43,17.624a3.254,3.254,0,0,0-1.625-.436H4.44a2.377,2.377,0,0,1-2.375-2.375V9.187A2.378,2.378,0,0,1,4.44,6.811H7.805A3.257,3.257,0,0,0,9.43,6.377L13.1,4.259A1.438,1.438,0,0,1,15.255,5.5V18.5a1.423,1.423,0,0,1-.718,1.245A1.439,1.439,0,0,1,13.817,19.936ZM4.44,7.811A1.377,1.377,0,0,0,3.065,9.187v5.626A1.377,1.377,0,0,0,4.44,16.188H7.805a4.247,4.247,0,0,1,2.125.571L13.6,18.876a.437.437,0,0,0,.439,0,.433.433,0,0,0,.218-.379V5.5a.438.438,0,0,0-.657-.379L9.93,7.242a4.25,4.25,0,0,1-2.125.569Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M17.606,14.445a.5.5,0,0,1-.7-.711c.17-.169.34-.349.52-.52l1.21-1.209c-.57-.581-1.15-1.161-1.73-1.74a.5.5,0,0,1,.7-.71l1.74,1.739,1.74-1.739a.5.5,0,0,1,.7.71l-1.73,1.74,1.73,1.729a.5.5,0,0,1-.7.711L19.343,12.7Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
