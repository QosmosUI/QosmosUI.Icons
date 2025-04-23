// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSpiralArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M100.44 11.777V63.3l68.027 68.024v-51.52L100.44 11.776zM36.8 26.087l-10.538 10.26L153.64 163.565c2.86-4.157 5.824-8.042 8.887-11.75L36.8 26.087zm-24.71 74.044l68.025 68.024h51.676L63.683 100.13H12.09zM256.006 124.1c-24.66.192-51.354 10.48-75.348 34.718-34.8 35.155-56.222 127.215-18.105 159.436-7.546-35.653-5.986-77.632 26.35-119.467l.035.033c.61-.843 1.23-1.655 1.853-2.46 1.778-2.217 3.668-4.433 5.624-6.647.645-.697 1.29-1.393 1.945-2.065l-.063-.063c1.287-1.413 2.606-2.825 3.97-4.236 43.752-45.324 119.946-3.634 89.938 65.992h.29c-2.88 6.677-6.74 13.608-11.702 20.742l-69.31-69.31c-3.294 3.37-6.317 7.044-9.17 11.406l70.322 70.234c-8.92 15.136-13.956 30.713-15.79 45.766h-.263c-2.245 18.27.347 35.66 6.412 50.576 4.115 10.427 9.893 19.66 16.947 27.103l.156-.27c5.984 6.286 12.834 11.354 20.29 14.866 66.005 31.093 128.726 54.608 196.23 76.507l-.17-.443.546.222-7.408-18.144C458.28 396.92 427.07 318.55 403.172 235.316l-.002.006c.26 43.795-9.063 78.84-23.848 106.828l30.157 30.41c3.617-5.407 6.83-11.114 9.633-17.115l43.762 107.176L354.9 418.538c6.27-2.965 12.17-6.26 17.705-9.865l-29.255-29.268c-23.927 6.417-50.26-12.102-52.73-42.904-.008-.123-.02-.244-.03-.367-.06-.83-.097-1.67-.123-2.516-.006-.21-.02-.417-.024-.63-.02-1.007-.02-2.024.012-3.055.257-8.665 1.45-17.172 3.838-25.893l87 86.89 6.375 6.38c3.645-3.183 7.075-6.54 10.29-10.064l-28.528-28.53-69.84-69.84c4.99-11.8 12.255-24.317 22.402-38.37 19.266-26.68 21.558-53.408 13.063-75.332-.214-.565-.44-1.123-.668-1.682l-.012-.027c-11.07-27.104-38.573-46.637-70.787-49.108-2.502-.19-5.03-.28-7.582-.26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
