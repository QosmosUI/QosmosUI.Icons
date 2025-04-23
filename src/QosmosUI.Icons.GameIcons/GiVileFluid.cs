// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiVileFluid : ComponentBase
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
		builder.AddAttribute(14, "d", "M260.875 18.375C220.39 207.41 99.905 207.03 99.905 339.563c0 89.282 81.826 153.843 160.97 153.843 80.922 0 157.78-64.24 157.78-147.312 0-127.22-115.946-139.043-157.78-327.72zM164.72 224.53c20.58 28.427 49.463 50.325 84.843 67.126-52.21 33.95-104.512 4.16-84.844-67.125zm186.56 0c19.67 71.285-32.632 101.076-84.842 67.126 35.38-16.8 64.262-38.7 84.843-67.125zm-228.467 91c13.56 15.95 31.694 29.396 52.968 39.25.824 19.023 7.407 34.174 23.75 53.376-.656-16.11.23-30.838 3.876-43.125 17.655 5.02 36.742 7.75 56.656 7.75 18.736 0 36.733-2.438 53.5-6.905 3.442 12.116 4.3 26.536 3.657 42.28 15.894-18.673 22.544-33.512 23.655-51.81 22.768-9.975 42.15-24.008 56.438-40.814-1.84 57.177-40.896 105.505-94.625 122.533L291.75 403.78l-12.625 39.564c-6.228.84-12.593 1.28-19.063 1.28-6.468 0-12.834-.44-19.062-1.28l-12.625-39.563-10.938 34.283c-53.73-17.03-92.788-65.358-94.625-122.532z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
