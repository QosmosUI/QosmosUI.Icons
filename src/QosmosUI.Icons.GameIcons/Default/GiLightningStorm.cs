// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLightningStorm : ComponentBase
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
		builder.AddAttribute(14, "d", "M386.97 17.688c-.678 24.347-8.144 49.282-22.19 71.843-37.465 60.192-112.748 86.84-181.874 69.907 5.208-2.31 10.233-4.83 15.03-7.593 39.057-22.5 57.284-55.454 54.314-91.688-7.388 21.814-24.62 41.314-50.22 56.063-48.047 27.68-118.01 31.687-187.468 16.936v37.375c41.04 8.176 82.086 9.6 118.563 3.47.365.25.726.503 1.094.75l.093-.03 3.28 2.124c32.687 21.385 79.955 25.336 123.75 16.28 43.797-9.054 83.514-31.274 101.126-57.343l4-5.905 6.75 2.28c39.1 13.354 75.938 17.096 119.06 14.94.718-.056 1.442-.098 2.158-.157v-39.125c-36.865 3.595-75.212.762-111.407-9.032 9.5-26.66 10.5-54.67 3.94-81.093zM323.75 191.28c-17.796 9.052-37.843 15.86-58.625 20.157-31.336 6.48-64.594 7.087-94.688-.53L251.28 305l-93.06 20.375L457.874 495.97 348.53 319.936l58.064-14.968-82.844-113.69z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
