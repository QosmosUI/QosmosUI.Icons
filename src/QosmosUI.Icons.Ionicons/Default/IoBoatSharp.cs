// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBoatSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M477.77,246.42c-2.13-6-7.23-9.55-12.56-11.95L432,221.38V92a20,20,0,0,0-20-20H336V40a16,16,0,0,0-16-16H192a16,16,0,0,0-16,16V72H100A20,20,0,0,0,80,92V221.46L46.92,234.52c-5.33,2.4-10.58,6-12.72,12s-3.16,11.81-1,19L84.25,415.7h1.06c34.12,0,64-17.41,85.31-43.82C191.94,398.29,221.8,414,255.92,414s64-15.76,85.31-42.17c21.32,26.41,51.18,43.87,85.3,43.87h1.06l51.25-150.17C481,259.53,479.91,252.43,477.77,246.42ZM256,152,112,208.83V108a4,4,0,0,1,4-4H396a4,4,0,0,1,4,4V208.76Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M345.22,407c-52.25,36.26-126.35,36.25-178.6,0,0,0-45.64,63-94.64,63l13.33,1c29.86,0,58.65-11.73,85.31-25.59a185.33,185.33,0,0,0,170.6,0c26.66,13.87,55.45,25.6,85.31,25.6l13.33-1C392.21,470,345.22,407,345.22,407Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
