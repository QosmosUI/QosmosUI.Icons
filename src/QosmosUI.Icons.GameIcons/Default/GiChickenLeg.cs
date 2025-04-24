// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiChickenLeg : ComponentBase
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
		builder.AddAttribute(14, "d", "M395.938 20.78c-2.006-.015-4.02.047-6.063.19-20.603 1.434-43.834 11.255-68.156 33.374 4.478 1.835 8.86 4.388 13.092 7.718 34.186 26.906 13.31 54.375-13.156 48.094 35.578 39.36.977 69.643-36.97 49.625 9.69 25.352-20.15 40.428-47.155 17.845-19.576 41.963-23.738 70.97-24.53 95.094-.367 11.177 1.214 16.963 2.438 19.186 1.223 2.223 1.6 2.25 4.312 2.97 2.712.717 7.356.912 13 2.937 4.195 1.504 8.805 4.67 12.25 9.375 38.097 2.08 94.528 3.21 171.78-36.72 44.882-23.197 67.256-59.045 74.25-96.937 6.997-37.89-2.012-77.89-21.124-107.218-17.917-27.495-43.88-45.288-73.97-45.53zm64.187 69.44c25.656 51.76 6.995 94.552-63.844 126.218 35.36-38.065 64.82-79.05 63.845-126.22zm11.47 99C433.257 241.533 370.29 291.44 281 289.124c65.092-22.673 133.782-58.816 190.594-99.906zM200.06 302.562c-43.083 40.035-103.853 84.81-128.687 94.062-25.69 9.57-34.904.96-49.156 18.313-13.558 16.133 12.31 53.08 41.28 32.78-26.414 41.35 26.314 74.03 42.375 16.063 12.69-47.362 76.407-102.028 125.313-143.155l-.313-.688c-1.52-3.575-2.215-3.734-4.438-4.53-2.222-.798-6.236-1.084-11.468-2.47-4.804-1.27-10.963-4.467-14.907-10.375z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
