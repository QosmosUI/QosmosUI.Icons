// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBandage : ComponentBase
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
		builder.AddAttribute(14, "d", "M275.8,157a16,16,0,0,0-22.63,0l-93.34,93.34a16,16,0,0,0,0,22.63l79.2,79.2h0a16,16,0,0,0,22.63,0L355,258.83a16,16,0,0,0,0-22.63Z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M137.21,295.6a47.81,47.81,0,0,1-9.43-13.38L69,341a72.2,72.2,0,0,0,0,102h0a72.37,72.37,0,0,0,102,0l58.77-58.76a47.81,47.81,0,0,1-13.38-9.43Z");
		builder.AddAttribute(18, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M392,48a71.55,71.55,0,0,0-51,21l-55.92,55.91a48.05,48.05,0,0,1,13.36,9.45l79.19,79.19a48.05,48.05,0,0,1,9.45,13.36L443,171A72,72,0,0,0,392,48Z");
		builder.AddAttribute(21, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M275.8,157a16,16,0,0,0-22.63,0l-93.34,93.34a16,16,0,0,0,0,22.63l79.2,79.2h0a16,16,0,0,0,22.63,0L355,258.83a16,16,0,0,0,0-22.63ZM219.31,267.31a16,16,0,1,1,0-22.62A16,16,0,0,1,219.31,267.31Zm48,48a16,16,0,1,1,0-22.62A16,16,0,0,1,267.31,315.31Zm0-96a16,16,0,1,1,0-22.62A16,16,0,0,1,267.31,219.31Zm48,48a16,16,0,1,1,0-22.62A16,16,0,0,1,315.31,267.31Z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M465.61,46.39a104.38,104.38,0,0,0-147.25,0L248.6,116.28a4,4,0,0,0,4.2,6.58,35.74,35.74,0,0,1,11.69-2.54,47.7,47.7,0,0,1,33.94,14.06l79.19,79.19a47.7,47.7,0,0,1,14.06,33.94,35.68,35.68,0,0,1-2.54,11.69,4,4,0,0,0,6.58,4.2l69.89-69.76a104.38,104.38,0,0,0,0-147.25Z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M254.34,386.83a47.91,47.91,0,0,1-33.94-14L141.21,293.6a47.81,47.81,0,0,1-9.43-13.38c-4.59-9.7-1.39-25,2.48-36.9a4,4,0,0,0-6.64-4L50.39,316.36A104.12,104.12,0,0,0,197.64,463.61l72.75-72.88a4,4,0,0,0-4.21-6.58C262,385.73,257.78,386.83,254.34,386.83Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
