// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLanternFlame : ComponentBase
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
		builder.AddAttribute(14, "d", "M256.53 19.094c-28.53 0-51.842 23.313-51.842 51.843 0 13.565 5.28 25.95 13.875 35.22l-110.532 78.53h296.814l-110.594-78.25c8.755-9.297 14.156-21.8 14.156-35.5 0-28.53-23.344-51.843-51.875-51.843zm0 18.687c18.432 0 33.19 14.727 33.19 33.157 0 9.792-4.177 18.538-10.845 24.594l-22.72-16.06-22.25 15.81c-6.497-6.044-10.53-14.687-10.53-24.343 0-18.43 14.726-33.156 33.156-33.156zM96.44 204l3.343 11.875 65.376 232.75 1.906 6.813h178.876l1.937-6.813 65.375-232.75L416.594 204H96.437zm24.656 18.688h270.812L331.78 436.75H181.25l-60.156-214.063zm146.187 16.687c29.012 47.73-76.807 70.517-60.155 133.75 11.2 25 29.146 41.394 50.22 42.03 48.84 0 73.57-53.528 60.75-99.842-4.847 24.07-24.934 34.845-34.876 22.375-24.115-30.248 36.436-56.768-15.94-98.313zM127.25 473.72v18.686h258.594V473.72H127.25z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
